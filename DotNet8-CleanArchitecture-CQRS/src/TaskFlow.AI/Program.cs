using System.Text.Json;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.Ollama;

var endpoint = Environment.GetEnvironmentVariable("OLLAMA_ENDPOINT") ?? "http://localhost:11434";
var model = Environment.GetEnvironmentVariable("OLLAMA_MODEL") ?? "llama3.2";

Console.WriteLine("TaskFlow AI - Semantic Kernel + Ollama");
Console.WriteLine($"Endpoint: {endpoint}");
Console.WriteLine($"Model:    {model}");
Console.WriteLine();

var builder = Kernel.CreateBuilder();
builder.AddOllamaChatCompletion(modelId: model, endpoint: new Uri(endpoint));
var kernel = builder.Build();

var ticket = """
Customer: Acme Manufacturing
Issue: Our production dashboard has been unavailable since 09:15. Operators receive HTTP 503 when opening the dashboard. This is blocking the morning production shift. We already restarted the browser and the issue affects multiple workstations. Please investigate urgently.
""";

Console.WriteLine("INPUT TICKET");
Console.WriteLine(ticket);
Console.WriteLine(new string('-', 72));

var extractionPrompt = """
You are an enterprise support-ticket analyst.
Extract structured data from the ticket below.

Return ONLY valid JSON. Do not use markdown fences. Do not add commentary.
Use exactly these properties:
{
  "customer": "string",
  "category": "Incident|ServiceRequest|Question|Access",
  "priority": "P1|P2|P3|P4",
  "summary": "string",
  "sentiment": "Positive|Neutral|Negative|Urgent",
  "impact": "string",
  "actionItems": ["string"]
}

Ticket:
{{$ticket}}
""";

var extraction = await kernel.InvokePromptAsync(
    extractionPrompt,
    new KernelArguments { ["ticket"] = ticket });

var extractedJson = extraction.ToString().Trim();

var validationPrompt = """
You are an enterprise data-quality validator.
Normalize the supplied support-ticket JSON.

Rules:
- Return ONLY valid JSON.
- Preserve the exact property names.
- category must be one of Incident, ServiceRequest, Question, Access.
- priority must be one of P1, P2, P3, P4.
- sentiment must be one of Positive, Neutral, Negative, Urgent.
- actionItems must always be a JSON array of strings.
- If the ticket describes an outage affecting production users, priority must be P1 or P2.

Candidate JSON:
{{$candidateJson}}
""";

var normalized = await kernel.InvokePromptAsync(
    validationPrompt,
    new KernelArguments { ["candidateJson"] = extractedJson });

var normalizedJson = normalized.ToString().Trim();

try
{
    using var document = JsonDocument.Parse(normalizedJson);
    var prettyJson = JsonSerializer.Serialize(
        document.RootElement,
        new JsonSerializerOptions { WriteIndented = true });

    Console.WriteLine("STRUCTURED OUTPUT");
    Console.WriteLine(prettyJson);
    Console.WriteLine();
    Console.WriteLine("Orchestration: ticket -> extraction prompt -> validation/normalization prompt -> JSON");
    Console.WriteLine("Provider: Ollama (local model) via Semantic Kernel");
}
catch (JsonException)
{
    Console.Error.WriteLine("The local model did not return valid JSON after normalization.");
    Console.Error.WriteLine(normalizedJson);
    Environment.ExitCode = 1;
}
