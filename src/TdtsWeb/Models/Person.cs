namespace TdtsWeb.Models;

public sealed record Person(string Id, string Name, string? Photo = null, string? GitHubUserName = null);

/// <summary>Author ids used in blog front matter (<c>authors: [chris]</c>).</summary>
public static class People
{
    private static readonly Dictionary<string, Person> _all = new(StringComparer.OrdinalIgnoreCase)
    {
        ["chris"] = new("chris", "Chris Gomez", "img/hosts/chris.jpg"),
        ["rich"] = new("rich", "Rich Ross", "img/hosts/rich.jpg"),
    };

    public static IReadOnlyCollection<Person> All => _all.Values;

    /// <summary>Known ids resolve to a person; unknown values are shown as written.</summary>
    public static Person Resolve(string idOrName) =>
        _all.TryGetValue(idOrName, out var person) ? person : new Person(idOrName, idOrName);
}
