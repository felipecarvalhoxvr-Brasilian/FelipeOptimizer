# Backend

System-facing core of FelipeOptimizer. Handles Windows analysis, safe optimization orchestration, health monitoring, and local API exposure to the frontend.

## Proposed stack

- **.NET 8** (LTS)
- **Clean Architecture** (Domain -> Application -> Infrastructure)
- **Local IPC**: Named pipes or gRPC over localhost (no external network by default)

## Solution layout (planned)

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

## Status

Scaffold only. No optimization modules implemented yet.
