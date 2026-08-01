# Safety Model

Safety is the core architectural constraint.

## Safety tiers
- T0 Observe: read-only
- T1 Safe: reversible, low-risk
- T2 Review: requires confirm
- T3 Advanced: typed confirm + advanced mode
- T4 Blocked: never executed

## Hard blocks
No arbitrary registry edits, no disabling Defender/Update/firewall, no deletes outside allowlists.

## Safety Gate pipeline
Validate -> tier check -> allowlist -> consent -> audit pre -> execute -> audit post

## AI
Suggestions only from structured scan data; all actions pass Safety Gate.
