namespace TdtsWeb;

/// <summary>Site-wide constants. Change links here, not in components.</summary>
public static class SiteInfo
{
    public const string Title = "The Dev Talk Show";
    public const string Tagline = "Developers doing what developers do, recorded live.";
    public const string Url = "https://thedevtalkshow.com";

    /// <summary>When the show streams. Shown large on the home page.</summary>
    public const string LiveTime = "7:45";
    public const string LiveWhen = "a.m. Eastern, before standup.";

    public const string YouTube = "https://www.youtube.com/channel/UC2iybVI2TE2LQ6straknrnA";
    public const string Twitch = "https://www.twitch.tv/thedevtalkshow";

    /// <summary>Public GitHub repo URL. Links to it are hidden while empty.</summary>
    public const string GitHubRepo = "https://github.com/thedevtalkshow/tdtsweb";

    public static string? SourceUrl(string contentFolder, string fileName) =>
        string.IsNullOrEmpty(GitHubRepo)
            ? null
            : $"{GitHubRepo}/blob/main/src/TdtsWeb/Content/{contentFolder}/{fileName}.md";
}
