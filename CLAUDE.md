# CLAUDE.md

Guidance for Claude Code in this repo. **This file is public** — never put secrets, internal URLs, or private notes here. Personal instructions go in `CLAUDE.local.md` (git-ignored).

## What this is
Website for The Dev Talk Show (thedevtalkshow.com). Editors: Chris Gomez and Rich Ross, who publish via Markdown + pull requests.

## Stack
- .NET 10, Blazor components, BlazorStatic generates static HTML into `output/`.
- Markdown content in `src/TdtsWeb/Content/` with YAML front matter (see `docs/content-model.md`).
- Hosting: Azure Static Web Apps (free tier), PR preview environments, deploy from `main`.
- No database, no server runtime in production.

## Commands
- Run with live reload + generate: `dotnet watch` (in `src/TdtsWeb`)
- Build: `dotnet build`
- Generate like CI: `dotnet run -c Release --no-launch-profile` with `ASPNETCORE_ENVIRONMENT=Production` (writes `output/` and exits)
- BlazorStatic reads Markdown from the build output folder, so new content files need a rebuild (dotnet watch handles this).

## Conventions
- C#: file-scoped namespaces, `_camelCase` private fields, nullable enabled. Follow `.editorconfig`.
- Keep components small; shared layout in `Components/Layout/`. Site-wide links/titles live in `SiteInfo.cs`; authors in `Models/Person.cs`.
- Pages are rendered to static HTML: no interactive render modes, no server-side state. Small client behavior = plain JS.
- Styling is plain CSS in `wwwroot/css/site.css` following `docs/design.md` (tokens, rules). No CSS frameworks or CDNs.
- Content schema changes must update `docs/content-model.md`.
- Significant choices get a short ADR in `docs/decisions/` (next number, `NNNN-title.md`).

## Working files
- Put plans, notes, and throwaway output in `.scratch/` (git-ignored). Do not create ad-hoc markdown files elsewhere in the repo.
- Never commit generated `output/`, `bin/`, `obj/`.
