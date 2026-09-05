# .NET 8 Clean Architecture + CQRS API

A portfolio-grade ASP.NET Core .NET 8 Minimal API demonstrating Clean Architecture, CQRS, EF Core, validation, domain rules, global error handling, OpenAPI, health checks, tests, Docker, and CI.

## Architecture

```text
src/
  TaskFlow.Api             -> HTTP / Minimal API / composition root
  TaskFlow.Application     -> Commands, queries, handlers, DTOs, validation
  TaskFlow.Domain          -> Entities, value objects, domain rules
  TaskFlow.Infrastructure  -> EF Core, SQLite, repositories, persistence

tests/
  TaskFlow.Application.Tests
  TaskFlow.Api.Tests
```

Dependencies point inward: Domain has no infrastructure dependency; Application depends on Domain; Infrastructure implements Application contracts; API composes the system.

## Stack

- .NET 8 / ASP.NET Core Minimal APIs
- C# 12
- Entity Framework Core 8
- SQLite by default for zero-friction local execution
- MediatR for CQRS dispatching
- FluentValidation
- xUnit + FluentAssertions
- Swagger/OpenAPI
- Docker
- GitHub Actions

## Features

- Create, read, update and complete tasks
- CQRS command/query separation
- Domain entity with business invariants
- EF Core persistence and migrations
- FluentValidation pipeline
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

The project intentionally avoids putting business logic into endpoint delegates. Endpoints translate HTTP concerns into application requests; handlers coordinate use cases; domain objects enforce invariants; Infrastructure owns persistence details.

This is a learning/portfolio reference implementation, not a claim that every enterprise system should use every pattern shown here.
