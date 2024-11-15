using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    AdministradorADOEF administradorADOEF = new AdministradorADOEF();
    List<Administrador> administradores = administradorADOEF.ListarTodos();
    
    return administradores;
});

app.MapPost("/", ([FromBody] Administrador administrador) => { 
    AdministradorADOEF administradorADOEF = new AdministradorADOEF();
    administradorADOEF.Adicionar(administrador);
    return Results.Ok("Sucesso");
});

app.MapGet("/feedbacks", () => {
    FeedbackDAO feedbackDAO = new FeedbackDAO();
    List<Feedback> feedbacks = feedbackDAO.ListarTodos();

    return feedbacks;
});

app.MapPost("/feedback", ([FromBody] Feedback feedback) => {
    FeedbackDAO feedbackDAO = new FeedbackDAO();
    feedbackDAO.Adicionar(feedback);
    return Results.Ok("Sucesso");
});

app.Run();
