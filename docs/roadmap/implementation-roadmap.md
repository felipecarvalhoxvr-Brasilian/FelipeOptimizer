# Implementation Roadmap

Phased delivery plan for FelipeOptimizer. **No optimization features until architecture approval and M1 completion.**

## Phase 0 - Foundation (current)

| Item | Status |
|------|--------|
| Repository structure | Done |
| Architecture documentation | Done |
| ADR 001 tech stack | Proposed |
| CI skeleton | Done |
| Dev environment scripts | Done |

**Exit criteria:** Stakeholder approval of ADR 001 + folder layout.

## Phase 1 - M1: Core Scaffold

**Goal:** Runnable backend + frontend shell with health check only.

- Create .NET solution and projects (backend)
- Serilog + configuration
- GET /health local API
- WinUI 3 empty app shell
- OpenAPI v1 stub (shared/contracts)
- CI: build + test on Windows

**Exit criteria:** dotnet build green; app launches; /health returns version.

## Phase 2 - M2: System Analyzer (read-only)

**Goal:** Observation only, zero mutations.

- SystemSnapshot domain model
- WMI + OS version provider
- CPU/RAM/disk summary
- RunSystemScan use case
- Dashboard UI (read-only)

## Phase 3 - M3: Temp Cleaner (T1 safe tier)

**Goal:** First safe mutating feature with full safety gate.

- Path allowlist policy
- Dry-run preview + consent apply flow
- Audit log for deletes

## Phase 4 - M4: Startup and Storage

- Startup analyzer (T0) and disable (T3)
- Large file / storage analyzer (T0)

## Phase 5 - M5: Services, Performance, Security

- Service advisor (recommend only)
- Performance monitor
- Security posture check

## Phase 6 - M6: AI Advisor

- Structured prompts from SystemSnapshot
- Local model default; optional cloud with opt-in

## Phase 7 - M7: Installer and Release

- MSI/EXE packaging, code signing, E2E VM tests

## Out of scope (v1)

Registry optimization, driver management, remote fleet management, macOS/Linux clients.