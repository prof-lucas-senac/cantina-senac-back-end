public class AdministradorDAOEF
{
    public void Adicionar(Administrador administrador) {
        try
        {
            CantinaSenacContext context = new CantinaSenacContext();
            context.Administrador.Add(administrador);
            context.SaveChanges();
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
        }

    }
    public List<Administrador> ListarTodos(){
        try
        {
            CantinaSenacContext context = new CantinaSenacContext();
            List<Administrador> administradores = context.Administrador.ToList();
            return administradores;
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
            return null;
        }
    }

    public void Atualizar(Administrador administrador) {
        try
        {
            CantinaSenacContext context = new CantinaSenacContext();
            context.Administrador.Update(administrador);
            context.SaveChanges();
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }

    public void Deletar(Administrador administrador) {
        try
        {
            CantinaSenacContext context = new CantinaSenacContext();
            context.Administrador.Remove(administrador);
            context.SaveChanges();
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}