// See https://aka.ms/new-console-template for more information

//new TelaCadastroAdministrador();

//Conexao conexao = new Conexao();
//conexao.Criar();

//new TelaLogin();

Console.WriteLine("o que vc dejesa fazer?");
Console.WriteLine("1. Inserir Administrador");
Console.WriteLine("2. Listar Administrador");
Console.WriteLine("3. Atualizar Administrador");
Console.WriteLine("4. Deletar Administrador");
int opcao = Convert.ToInt32(Console.ReadLine());

string nomeUsuario;
string email;
string senha;
string foto;
int id;
Administrador administrador;
AdministradorDAO administradorDAO;

switch (opcao) {
    case 1:
        Console.WriteLine("Digite o nome de usuario");
        nomeUsuario = Console.ReadLine();
        Console.WriteLine("Digite seu email:");
        email = Console.ReadLine();
        Console.WriteLine("Digite sua senha:");
        senha = Console.ReadLine();
        Console.WriteLine("Digite sua foto:");
        foto = Console.ReadLine();
        administrador = new Administrador() {
            NomeUsuario = nomeUsuario,
            Email = email,
            Senha = senha,
            Foto = foto
        };
        /*AdministradorDAO*/administradorDAO = new AdministradorDAO();
        administradorDAO.Adicionar(administrador);
        break;
    case 2:
        administradorDAO = new AdministradorDAO();
        List<Administrador> administradores = administradorDAO.ListarTodos();
        Console.WriteLine("Lista de Administradores");
        foreach (Administrador administrador1 in administradores) {
            Console .WriteLine(administrador1.NomeUsuario);
        }
        break;
    case 3:
        Console.WriteLine("Digite o Id do Administrador");
        id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o novo nome de usuario");
        nomeUsuario = Console.ReadLine();
        Console.WriteLine("Digite seu novo email:");
        email = Console.ReadLine();
        Console.WriteLine("Digite sua novo senha:");
        senha = Console.ReadLine();
        Console.WriteLine("Digite sua novo foto:");
        foto = Console.ReadLine();
        /*Administrador*/administrador = new Administrador() {
            Id = id,
            NomeUsuario = nomeUsuario,
            Email = email,
            Senha = senha,
            Status = 1,
            Foto = foto
        };
        administradorDAO = new AdministradorDAO();
        administradorDAO.Atualizar(administrador);
        break;
    case 4:
    Console.WriteLine("Digite o Id do Administrador a ser");
        id = Convert.ToInt32(Console.ReadLine());
        /*Administrador*/administrador = new Administrador() {
            Id = id,
        };
        /*AdministradorDAO*/administradorDAO = new AdministradorDAO();
        administradorDAO.Deletar(administrador);
        break;
    default:
    Console.WriteLine("Você não escolheu um opção valida!");
        break;
}