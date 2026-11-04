# 0001 — Static site with BlazorStatic, Markdown in Git, Azure Static Web Apps

- Status: Accepted
- Date: 2026-10-28

## Context
The old site is a single static page and can't be updated in practice. Two editors (Chris, Rich) want to write blog posts in Markdown. A .NET stack is preferred, and the repo will be public on GitHub. No current need for roles beyond those two editors.

## Decision
- **Generator:** BlazorStatic (Blazor components → static HTML at build time, Markdig for Markdown).
- **Content:** Markdown + YAML front matter, stored in the repo.
- **Editing / auth:** GitHub is the login. Editors are repo collaborators; posts go through PRs. No site login.
- **Hosting:** Azure Static Web Apps free tier, with PR preview environments and a custom domain.

## Alternatives considered
- **Orchard Core / Umbraco:** full CMS with an admin UI and roles, but needs an always-on host and a database. Too heavy for two editors.
- **Statiq:** .NET static generator, but development has slowed.
- **Hugo / Astro:** mature, but not .NET.
- **Hand-rolled (Markdig + Razor prerender):** viable fallback if BlazorStatic stalls.

## Consequences
- BlazorStatic is still pre-1.0 and maintained by a small team. Risk is limited because content is portable Markdown; swapping generators doesn't touch content.
- If non-Git editors join, add a Git-based CMS (Sveltia or Decap) at `/admin`, or turn on Static Web Apps auth and roles. Neither requires a rewrite.
