public class TelaCadastroAdministrador : ITela
{
    public TelaCadastroAdministrador() {
        ExibirTela();
    }
    public void ExibirTela() {
        
        string nomeUsuario;
        string email;
        string senha;
        string status;
        string foto;
        System.Console.WriteLine("Cantina Senac - Cadastro de Administrador\n");
        System.Console.WriteLine("Digite o nome do usuario");
        nomeUsuario = Console.ReadLine();
        System.Console.WriteLine("Digite o seu email");
        email = Console.ReadLine();
        System.Console.WriteLine("Digite a sua senha:");
        senha = Console.ReadLine();
        System.Console.WriteLine("Insira a sua foto de perfil");
        foto = Console.ReadLine();

        Administrador administrador = new Administrador() {
            NomeDoUsuario = nomeUsuario,
            Email = email,
            Senha = senha,
            Foto = foto,
            Status = 1
        };

        AdministradorDAO administradorDAO = new AdministradorDAO();
        administradorDAO.Adicionar(administrador);

        new TelaLogin();
    }
}