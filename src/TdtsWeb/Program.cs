using BlazorStatic;
using TdtsWeb;
using TdtsWeb.Components;
using TdtsWeb.Models;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseStaticWebAssets();

builder.Services.AddBlazorStaticService(opt =>
    {
        opt.ShouldGenerateSitemap = true;
        opt.SiteUrl = SiteInfo.Url;
    })
    .AddBlazorStaticContentService<PostFrontMatter>(opt =>
    {
        opt.ContentPath = Path.Combine("Content", "Blog");
        opt.PageUrl = "blog";
    })
    .AddBlazorStaticContentService<EpisodeFrontMatter>(opt =>
    {
        opt.ContentPath = Path.Combine("Content", "Episodes");
        opt.PageUrl = "episodes";
        opt.Tags.AddTagPagesFromPosts = false; // tag pages are blog-only for now
    });

builder.Services.AddRazorComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();
app.MapRazorComponents<App>();

// In Development the site keeps running (dotnet watch); otherwise it generates into output/ and exits.
app.UseBlazorStaticGenerator(shutdownApp: !app.Environment.IsDevelopment());

app.Run();
