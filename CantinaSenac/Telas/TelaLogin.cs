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

        AdministradorDAO_ADO administradorDAO = new AdministradorDAO_ADO();
        List<Administrador> administradores = administradorDAO.ListarTodos();

        foreach(Administrador administrador in administradores) {
            if (usuario == administrador.NomeUsuario) {
                Console.WriteLine("Usuário encontrado com sucesso");
            } else {
                Console.WriteLine("Usuario não encontrado");
            }
        }

        new TelaFeedback();
    }
}