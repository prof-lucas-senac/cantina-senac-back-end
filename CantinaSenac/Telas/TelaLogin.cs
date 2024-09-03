public class TelaLogin : ITela
{
    public void ExibirTela()
    {
        string usuario;
        string senha;
        System.Console.WriteLine("Cantina Senac - Seja bem-vind@\n");
        System.Console.WriteLine("Insira seu usuário:");
        usuario = Console.ReadLine();
        System.Console.WriteLine("Insira sua senha:");
        senha = Console.ReadLine();
    }
}