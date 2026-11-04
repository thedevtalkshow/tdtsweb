using BlazorStatic;

namespace TdtsWeb.Models;

/// <summary>Front matter for Content/Blog/*.md. Field reference: docs/content-model.md.</summary>
public sealed class PostFrontMatter : IFrontMatter, IFrontMatterWithTags
{
    public string Title { get; set; } = "";
    public string Lead { get; set; } = "";
    public DateTime Published { get; set; } = DateTime.Now;
    public DateTime? Updated { get; set; }
    public List<string> Authors { get; set; } = [];
    public List<string> Tags { get; set; } = [];
    public string? Image { get; set; }
    public bool IsDraft { get; set; }
    public AdditionalInfo? AdditionalInfo { get; set; }
}
