# Backend Architecture

## Purpose

The backend is the trust boundary for all Windows interactions. The frontend never touches the OS directly.

## Project structure

```
backend/
├── FelipeOptimizer.sln
├── Directory.Build.props
└── src/
    ├── FelipeOptimizer.Domain/
    ├── FelipeOptimizer.Application/
    ├── FelipeOptimizer.Infrastructure/
    ├── FelipeOptimizer.Api/
    └── FelipeOptimizer.SystemWorker/
```

## Layer details

### Domain
Entities, value objects, and interfaces. No OS or UI dependencies.

### Application
Use cases, safety gate, orchestration. CQRS-lite with Result types.

### Infrastructure
Windows adapters: WMI, performance counters, safe file operations.

### Api
Local-only host. OpenAPI from shared/contracts.

## Status
Scaffold phase only.
