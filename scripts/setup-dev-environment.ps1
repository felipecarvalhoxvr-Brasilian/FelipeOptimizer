#Requires -Version 5.1
Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

Write-Host "FelipeOptimizer - Dev Environment Check" -ForegroundColor Cyan

function Test-CommandExists { param([string]$Name)
  return $null -ne (Get-Command $Name -ErrorAction SilentlyContinue)
}

if (Test-CommandExists "dotnet") {
  $v = (dotnet --version).Trim()
  Write-Host ".NET SDK: $v" -ForegroundColor Green
} else {
  Write-Host ".NET SDK: MISSING - https://dot.net/download" -ForegroundColor Red
  exit 1
}

if (Test-CommandExists "git") {
  Write-Host "Git: OK" -ForegroundColor Green
} else {
  Write-Host "Git: MISSING - https://git-scm.com/download/win" -ForegroundColor Yellow
}

$os = Get-CimInstance Win32_OperatingSystem
Write-Host "OS: $($os.Caption)" -ForegroundColor Green
Write-Host "Ready for M1 scaffold." -ForegroundColor Cyan
