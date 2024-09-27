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
        
        if (usuario == Database.Administrador.NomeDoUsuario)
        {
            System.Console.WriteLine("Usuário encontrado com sucesso;");
        } else
        {
            System.Console.WriteLine("Usuário não encontrado");
        }
    }
}