# Design: "Before Standup"

The show streams before standup, so the site uses morning light: a cool white page, the logo's slate blue, and one rising sun behind the stream time on the home page. Styles live in `src/TdtsWeb/wwwroot/css/site.css` (plain CSS, no framework). Fonts are self-hosted in `wwwroot/fonts`.

## Tokens

| Token | Value | Use |
|---|---|---|
| `--paper` | `#f7fafc` | Page background |
| `--dawn` | `#e3eef5` | Footer band, inline code, hovers |
| `--ink` | `#1c2f3c` | Text, horizon line, code blocks |
| `--ink-soft` | `#4b5f6d` | Secondary text |
| `--slate` | `#578099` | The logo's color: date boxes, rules |
| `--slate-deep` | `#355d78` | Links (slate darkened for contrast) |
| `--sun` | `#f4b73a` | The sun and the primary button only |

Type: **Zilla Slab** (headings, date boxes; echoes the logo's boxed THE / SHOW) and **Instrument Sans** (body). The script lettering stays in the logo.

## Rules
- The sun is the one bold element. Don't add more yellow, gradients, or animation elsewhere.
- Lists of episodes and posts share one row pattern: a slab date box, a title, then a lead.
- Keep prose to about 66 characters per line (`--measure`).
- The show time is set in `SiteInfo.LiveTime` / `LiveWhen`.
