public class TelaLogin : ITela {
    public TelaLogin() {
        ExibirTela();
    }

    public void ExibirTela() {
        string usuario;
        string senha;

        Console.WriteLine("Cantina Senac - Seja bem-vind@\n");
        Console.WriteLine("Insira seu usuario");
        usuario = Console.ReadLine();
        Console.WriteLine("Insira sau senha");
        senha = Console.ReadLine();

        if(usuario == Database.Administrador.NomeUsuario) {
            Console.WriteLine("Usuário encontrado com sucesso");
        } else {
            Console.WriteLine("Usuario não encontrado");
        }

        new TelaFeedback();
    }
}