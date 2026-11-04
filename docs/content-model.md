# Content model

Field names are camelCase and must match exactly. All content is Markdown with YAML front matter under `src/TdtsWeb/Content/`.

## Blog post — `Content/Blog/*.md`

| Field | Type | Required | Notes |
|---|---|---|---|
| `title` | string | yes | |
| `lead` | string | yes | Summary for lists and social cards |
| `published` | date | yes | `yyyy-mm-dd` |
| `authors` | list | yes | Author ids: `chris`, `rich` |
| `tags` | list | no | Lowercase, hyphenated |
| `image` | string | no | Relative to `media/` |
| `isDraft` | bool | no | `true` = not published |

## Episode — `Content/Episodes/*.md`

Start from `Content/Episodes/_episode-template.md`.

| Field | Type | Required | Notes |
|---|---|---|---|
| `title` | string | yes | |
| `lead` | string | yes | Shown on episode cards |
| `aired` | date | yes | `yyyy-mm-dd` |
| `youtubeId` | string | yes | The `v=` value from the YouTube URL; drives the embed and thumbnail |
| `hosts` | list | no | Author ids: `chris`, `rich` |
| `guests` | list | no | Names as written |
| `tags` | list | no | Displayed as topics (no tag pages for episodes yet) |
| `isDraft` | bool | no | `true` = not published |

Body = show notes and links.

Planned: a scheduled GitHub Action runs a small .NET tool that pulls new videos from the YouTube Data API and opens a PR with new episode files.

## Authors

Defined in `src/TdtsWeb/Models/Person.cs`. Unknown ids are shown as written.

| Id | Name |
|---|---|
| `chris` | Chris Gomez |
| `rich` | Rich Ross |
