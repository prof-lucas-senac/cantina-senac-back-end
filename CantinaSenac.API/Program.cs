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

app.Run();
