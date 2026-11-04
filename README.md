# The Dev Talk Show — website

Source for [thedevtalkshow.com](https://thedevtalkshow.com): developers doing what developers do, recorded live.

Built with [BlazorStatic](https://github.com/tesar-tech/BlazorStatic) (Blazor → static HTML) and hosted on Azure Static Web Apps.

## Run it locally

Requires the .NET 10 SDK.

```bash
cd src/TdtsWeb
dotnet watch
```

The site runs at the URL printed in the console, and static HTML is generated into `src/TdtsWeb/output/`.

## Add a blog post

1. Create `src/TdtsWeb/Content/Blog/yyyy-mm-dd-short-title.md`.
2. Add front matter at the top (see [docs/content-model.md](docs/content-model.md)):

   ```markdown
   ---
   title: "My post title"
   lead: "One-sentence summary shown in lists."
   published: 2026-11-01
   authors: [chris]
   tags: [dotnet, azure]
   ---

   Post body in Markdown…
   ```

3. Put images in `Content/Blog/media/` and reference them as `media/my-image.png`.
4. Open a pull request. Azure Static Web Apps builds a preview URL; merge to publish.

You can do all of this from GitHub's web editor (press `.` on the repo to open github.dev).

## Add an episode

Copy `src/TdtsWeb/Content/Episodes/_episode-template.md` to `yyyy-mm-dd-short-title.md`, fill in `youtubeId` and the other fields, remove `isDraft: true`, and open a PR.

## Deployment

`.github/workflows/deploy.yml` generates the site and deploys `src/TdtsWeb/output` to Azure Static Web Apps. Pull requests get a preview URL. One-time setup: create a Static Web App (Free plan, deployment source "Other"), then add its deployment token as the repo secret `AZURE_STATIC_WEB_APPS_API_TOKEN`.

**Trial on GitHub Pages:** `.github/workflows/pages.yml` deploys every push to `main` to GitHub Pages. Enable it under Settings → Pages → Source: GitHub Actions. The workflow sets `BasePath` so the site works under `/<repo>/`.

## Repo layout

| Path | What's there |
|---|---|
| `src/TdtsWeb/` | The Blazor site (`SiteInfo.cs` holds links and titles) |
| `src/TdtsWeb/Content/` | Markdown content (blog, episodes) |
| `docs/` | Content model and architecture decision records |
| `CLAUDE.md`, `.claude/` | Shared instructions for Claude Code (personal/scratch files are git-ignored) |

## License

Code is MIT. Content is © its authors.
