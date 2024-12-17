using AsciiArtSvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => AsciiArt.AllFonts.Value);
app.MapGet("/{text}", (string text, string? font) => AsciiArt.Write(text, font));

app.Run();