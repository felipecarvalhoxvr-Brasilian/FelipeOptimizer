# Development Milestones

Concrete milestones with deliverables and acceptance tests.

## M0 - Architecture and Foundation (Week 1) - IN PROGRESS

### Deliverables
- [x] Repository folder structure
- [x] Architecture docs
- [x] ADR 001 tech stack (proposed)
- [x] Implementation roadmap
- [ ] Stakeholder sign-off

### Acceptance
- README explains vision, stack, and getting started
- No optimization code merged

## M1 - Solution Scaffold (Weeks 2-3)

### Deliverables
- .NET 8 solution with 5 backend projects
- WinUI 3 app shell
- GET /health endpoint
- Serilog file logging
- GitHub Actions CI
- scripts/setup-dev-environment.ps1

### Acceptance checklist
- [ ] dotnet build succeeds on Windows
- [ ] Frontend launches empty window
- [ ] /health returns status and version
- [ ] At least one unit test passes in CI

## M2 - System Analyzer Read-Only (Weeks 4-6)

### Deliverables
- System scan use case, dashboard with OS/CPU/RAM/disk summary

### Acceptance checklist
- [ ] Scan completes in under 60s on typical hardware
- [ ] Zero file/registry mutations during scan
- [ ] Manual test on Windows 10 and 11

## M3 - Safe Temp Cleaner (Weeks 7-9)

### Acceptance checklist
- [ ] Dry-run byte count matches apply
- [ ] Deletes outside allowlist are blocked
- [ ] Audit log records every delete

## M4 - Startup and Storage (Weeks 10-12)
## M5 - Services, Performance, Security (Weeks 13-16)
## M6 - AI Advisor (Weeks 17-20)
## M7 - Production Release (Weeks 21-24)

See docs/roadmap/implementation-roadmap.md for full phase details.