# .NET 8 Clean Architecture + CQRS API

A portfolio-grade ASP.NET Core .NET 8 Minimal API demonstrating Clean Architecture, CQRS and the engineering practices expected from a maintainable enterprise service.

## Requirements demonstrated

| Requirement | Implementation |
|---|---|
| Dependency Injection | ASP.NET Core built-in DI; interfaces registered at the composition root |
| Structured Logging | Serilog with structured properties and request logging |
| Global Exception Handling | Centralized exception handler returning ProblemDetails |
| Validation | FluentValidation integrated through a MediatR pipeline behavior |
| Unit Testing | xUnit + FluentAssertions |
| Integration Testing | xUnit + WebApplicationFactory exercising the real API pipeline |

## Architecture

```text
src/
  TaskFlow.Api             -> HTTP / Minimal API / composition root
  TaskFlow.Application     -> Commands, queries, handlers, DTOs, validation
  TaskFlow.Domain          -> Entities, value objects, domain rules
  TaskFlow.Infrastructure  -> EF Core, SQLite, repositories, persistence

tests/
  TaskFlow.Application.Tests -> unit tests
  TaskFlow.Api.Tests         -> API integration tests
```

Dependencies point inward: Domain has no infrastructure dependency; Application depends on Domain; Infrastructure implements Application contracts; API composes the system.

## Stack

- .NET 8 / ASP.NET Core Minimal APIs
- C# 12
- Entity Framework Core 8
- SQLite by default
- MediatR for CQRS dispatching
- FluentValidation
- Serilog
- ProblemDetails / global exception handling
- xUnit + FluentAssertions
- Swagger/OpenAPI
- Docker
- GitHub Actions

## Observability

Serilog is configured as the logging provider. Application events use structured properties rather than interpolated log strings, making logs easier to query in centralized observability platforms.

The request pipeline also uses Serilog request logging so HTTP method, path, status code, elapsed time and request correlation information are available in structured log events.

## Error handling

Unhandled exceptions are handled centrally and returned as ProblemDetails responses instead of leaking implementation details through individual endpoints. Expected validation failures are rejected by FluentValidation before command/query handlers execute.

## Testing strategy

### Unit tests

Application/domain behavior can be tested without starting a web server. Tests focus on use-case behavior and business rules.

### Integration tests

The API test project uses `WebApplicationFactory` to boot the ASP.NET Core application and exercise routing, dependency injection, middleware, validation and persistence together. This catches composition errors that isolated unit tests cannot.

## Features

- Create, read, update and complete tasks
- CQRS command/query separation
- Domain entity with business invariants
- EF Core persistence
- FluentValidation pipeline
- Serilog structured logging
- Global ProblemDetails error handling
- Pagination and filtering
- Health endpoint
- Unit and API integration tests
- Docker support
- CI build/test workflow

## Run

```bash
dotnet restore
dotnet build
dotnet test
dotnet run --project src/TaskFlow.Api
```

Open `/swagger` in Development and `/health` for a health check.

## Example API

```http
POST /api/tasks
Content-Type: application/json

{
  "title": "Implement CQRS",
  "description": "Build the command and query handlers",
  "priority": 2
}
```

```http
GET /api/tasks?page=1&pageSize=20&completed=false
GET /api/tasks/{id}
PUT /api/tasks/{id}
POST /api/tasks/{id}/complete
```

## Engineering practices demonstrated

The project intentionally avoids putting business logic into endpoint delegates. Endpoints translate HTTP concerns into application requests; handlers coordinate use cases; domain objects enforce invariants; Infrastructure owns persistence details; cross-cutting concerns such as validation, logging and exception handling are centralized.

This is a learning/portfolio reference implementation designed to demonstrate practical enterprise .NET engineering patterns.
