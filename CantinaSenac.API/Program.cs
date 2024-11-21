using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    AdministradorDAOEF administradorDAO = new AdministradorDAOEF();
    List<Administrador> administradores = administradorDAO.ListarTodos();
    return administradores;
});

app.MapPost("/", ([FromBody] Administrador administrador) => {
        AdministradorDAOEF administradorDAO = new AdministradorDAOEF();
        administradorDAO.Adicionar(administrador);
        return Results.Ok("Sucesso");
});

app.MapGet("/feedbacks", () => {
    FeedbackDAO feedbackDAO = new FeedbackDAO();
    List<Feedback> feedbacks = feedbackDAO.ListarTodos();
    return feedbacks;
});

app.MapPost("/feedbacks", ([FromBody] Feedback feedback) => {
    FeedbackDAO feedbackDAO = new FeedbackDAO();
    feedbackDAO.Adicionar(feedback);
    return Results.Ok("Deu boa piazada");
});

app.Run();
