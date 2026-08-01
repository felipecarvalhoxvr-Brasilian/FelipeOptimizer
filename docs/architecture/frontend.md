# Frontend Architecture

## Purpose

Trustworthy UI for informed consent before any system change.

## Pattern: MVVM

View (XAML) -> ViewModel -> BackendClientService -> Local API

## Planned screens
- Dashboard, Scan, Recommendations, Plan Review, History, Settings

## Safety UX
Every action shows safety tier, exact impact, reversibility, and explicit confirm.

## Stack
WinUI 3, CommunityToolkit.Mvvm (optional), OpenAPI-generated client.
