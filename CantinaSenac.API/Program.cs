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

app.Run();
