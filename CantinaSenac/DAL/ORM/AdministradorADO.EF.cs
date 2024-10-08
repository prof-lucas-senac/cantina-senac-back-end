public class AdministradorADOEF {
    public void Adicionar(Administrador administrador) {
        try {
            CantinaSenacContext context = new CantinaSenacContext();
            context.Administrador.Add(administrador);
            context.SaveChanges();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public List<Administrador> ListarTodos() {
        try {
            CantinaSenacContext context = new CantinaSenacContext();
            List<Administrador> administradors = context.Administrador.ToList();

            return administradors;
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public void Atualizar(Administrador administrador) {
        try {
            CantinaSenacContext context = new CantinaSenacContext();
            context.Administrador.Update(administrador);
            context.SaveChanges();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public void Deletar(Administrador administrador) {
        try {
            CantinaSenacContext context = new CantinaSenacContext();
            context.Administrador.Remove(administrador);
            context.SaveChanges();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}