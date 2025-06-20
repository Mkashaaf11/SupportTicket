using SupportTicket.Models;
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

var tickets = new List<Ticket>
{
    new Ticket{Id = 1,Title = "Bug Ticket" , Description = "It is s ticket for bug"},
    new Ticket {Id=2 , Title = "Login Issue", Description = "Unable to login", Status = "In Progress"}
};

app.MapGet("api/getTickets", () => { 

return Results.Ok(tickets);
});

app.Run();
