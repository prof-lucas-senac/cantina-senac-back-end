public class TelaCadastroAdministrador : ITela {
    public TelaCadastroAdministrador() {
        ExibirTela();
    }

    public void ExibirTela() {

        AdmnistradorDAO admnistradorDAO = new AdmnistradorDAO();
        admnistradorDAO.Adicionar(new Administrador());
        return;

        string nomeUsuario;
        string email;
        string senha;
        string status;
        string foto;

        Console.WriteLine("Cantina Senac - Cadastro de Administrador\n");
        Console.WriteLine("Digite o nome do usuario");
        nomeUsuario = Console.ReadLine();
        Console.WriteLine("Digite o seu email");
        email = Console.ReadLine();
        Console.WriteLine("Digite a sua senha:");
        senha = Console.ReadLine();
        Console.WriteLine("Insira a sua foto de perfil");
        foto = Console.ReadLine();

        new TelaLogin();
    }
}