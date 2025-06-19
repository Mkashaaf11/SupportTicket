var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/status", () =>
{
    return Results.Ok(new
    {
        status = "Working",
        time = DateTime.Now,
    });
});

app.Run();
