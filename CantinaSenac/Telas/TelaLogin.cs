public class TelaLogin : ITela
{
    public TelaLogin()
    {
        ExibirTela();
    }
    public void ExibirTela()
    {
        string usuario;
        string senha;
        System.Console.WriteLine("Cantina Senac - Seja bem-vind@\n");
        System.Console.WriteLine("Insira seu usuário:");
        usuario = Console.ReadLine();
        System.Console.WriteLine("Insira sua senha:");
        senha = Console.ReadLine();

        AdministradorDAO_ADO administradorDAO = new AdministradorDAO_ADO();
        List<Administrador> administradores = administradorDAO.ListarTodos();

        foreach (Administrador administrador in administradores){
            if (usuario == administrador.NomeDoUsuario) {
                System.Console.WriteLine("Usuário encontrado com sucesso;");
            } else {
                System.Console.WriteLine("Usuário não encontrado");
            }
        }
    }
}