using BlazorStatic;

namespace TdtsWeb.Models;

/// <summary>Front matter for Content/Episodes/*.md. Field reference: docs/content-model.md.</summary>
public sealed class EpisodeFrontMatter : IFrontMatter
{
    public string Title { get; set; } = "";
    public string Lead { get; set; } = "";
    public DateTime Aired { get; set; } = DateTime.Now;
    public string YoutubeId { get; set; } = "";
    public List<string> Hosts { get; set; } = [];
    public List<string> Guests { get; set; } = [];
    public List<string> Tags { get; set; } = [];
    public bool IsDraft { get; set; }
    public AdditionalInfo? AdditionalInfo { get; set; }

    public string ThumbnailUrl => $"https://i.ytimg.com/vi/{YoutubeId}/hqdefault.jpg";
    public string EmbedUrl => $"https://www.youtube-nocookie.com/embed/{YoutubeId}";
    public string WatchUrl => $"https://www.youtube.com/watch?v={YoutubeId}";
}
