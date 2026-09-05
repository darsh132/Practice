# TaskFlow AI — Semantic Kernel + Ollama

A runnable .NET 8 business-AI sample showing **Semantic Kernel orchestrating a local LLM through Ollama** for automated support-ticket intelligence.

## Evidence covered

- Semantic Kernel orchestration
- Local model through Ollama
- Llama 3.2 by default (configurable with `OLLAMA_MODEL`)
- Practical enterprise use case: structured JSON extraction
- Multi-step prompt orchestration: extraction -> validation/normalization
- Deterministic JSON parsing with `System.Text.Json`
- No cloud API key required

## Architecture

```text
Support Ticket
     |
     v
Semantic Kernel
     |
     +--> Prompt 1: extract business fields
     |        |
     |        v
     |    Candidate JSON
     |        |
     +--> Prompt 2: validate + normalize
              |
              v
        Validated JSON
```

The LLM is the reasoning component; the application remains responsible for the workflow, schema contract, validation boundary, and final JSON parsing.

## Prerequisites

1. Install .NET 8 SDK.
2. Install Ollama.
3. Start Ollama.
4. Pull a supported local model.

```bash
ollama serve
ollama pull llama3.2
```

If your machine has limited resources, you can use another Ollama chat model and set `OLLAMA_MODEL` accordingly.

## Run

From this directory:

```bash
dotnet restore
dotnet run
```

Or from the repository root:

```bash
dotnet run --project src/TaskFlow.AI/TaskFlow.AI.csproj
```

Optional configuration:

```bash
# Windows PowerShell
$env:OLLAMA_ENDPOINT="http://localhost:11434"
$env:OLLAMA_MODEL="llama3.2"

# Linux/macOS
export OLLAMA_ENDPOINT=http://localhost:11434
export OLLAMA_MODEL=llama3.2
```

## Example output

The exact wording can vary by local model, but the final response is normalized into this shape:

```json
{
  "customer": "Acme Manufacturing",
  "category": "Incident",
  "priority": "P1",
  "summary": "Production dashboard is unavailable and returns HTTP 503.",
  "sentiment": "Urgent",
  "impact": "Production operators across multiple workstations are blocked.",
  "actionItems": [
    "Investigate the production dashboard service",
    "Check service health and recent deployment changes",
    "Restore dashboard availability and communicate status"
  ]
}
```

## Why this is a business use case

This pattern can sit behind an ITSM/help-desk ingestion pipeline. Incoming tickets can be automatically classified, prioritized, summarized, and converted into machine-readable data before being routed to downstream systems.

The sample deliberately uses a local model so the workflow can be demonstrated without sending the ticket to a hosted AI provider.

## Technology

- .NET 8
- C#
- Semantic Kernel 1.45.0
- Semantic Kernel Ollama connector 1.45.0-alpha
- Ollama
- Llama 3.2
- System.Text.Json

## Production evolution

A production implementation could replace the hard-coded ticket with an API/event consumer, persist the extracted record, add confidence scoring and human review, emit structured telemetry, and route low-confidence results to a manual queue. The same orchestration boundary can later be switched to a hosted provider such as Gemini without changing the business workflow contract.
