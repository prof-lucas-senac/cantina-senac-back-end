var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    AdministradorADOEF administradorADOEF = new AdministradorADOEF();
    List<Administrador> administradores = administradorADOEF.ListarTodos();
    return administradores;
});

app.Run();
