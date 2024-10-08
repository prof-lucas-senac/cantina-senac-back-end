// See https://aka.ms/new-console-template for more information

// new TelaLogin();

System.Console.WriteLine("O que você deseja fazer?");
System.Console.WriteLine("1. Inserir Administrador;");
System.Console.WriteLine("2. Listar Administradores;");
System.Console.WriteLine("3. Atualizar Administrador;");
System.Console.WriteLine("4. Excluir Administrador;");
int opcao = Convert.ToInt32(Console.ReadLine());

string nomeUsuario = "";
string email = "";
string senha = "";
string foto = "";
int id;
Administrador administrador;
AdministradorDAOEF administradorDAO;
switch (opcao)
{
    case 1:
        System.Console.WriteLine("Digite o nome de usuário");
        nomeUsuario = Console.ReadLine();
        System.Console.WriteLine("Digite seu email:");
        email = Console.ReadLine();
        System.Console.WriteLine("Digite sua senha:");
        senha = Console.ReadLine();
        System.Console.WriteLine("Digite sua foto:");
        foto = Console.ReadLine();
        administrador = new Administrador(){
            NomeDoUsuario = nomeUsuario,
            Email = email,
            Senha = senha,
            Status = 1,
            Foto = foto
        };
        administradorDAO = new AdministradorDAOEF();
        administradorDAO.Adicionar(administrador);
        break;
    case 2:
        administradorDAO = new AdministradorDAOEF();
        List<Administrador> administradores = administradorDAO.ListarTodos();
        System.Console.WriteLine("Lista de Administradores:");
        foreach (Administrador adm in administradores) {
            System.Console.WriteLine(adm.NomeDoUsuario);
        }
        break;
    case 3:
        System.Console.WriteLine("Digite o Id do Administrador:");
        id = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite o novo nome de usuário");
        nomeUsuario = Console.ReadLine();
        System.Console.WriteLine("Digite o novo email:");
        email = Console.ReadLine();
        System.Console.WriteLine("Digite a nova senha:");
        senha = Console.ReadLine();
        System.Console.WriteLine("Digite a nova foto:");
        foto = Console.ReadLine();
        administrador = new Administrador(){
            Id = id,
            NomeDoUsuario = nomeUsuario,
            Email = email,
            Senha = senha,
            Status = 1,
            Foto = foto
        };
        administradorDAO = new AdministradorDAOEF();
        administradorDAO.Atualizar(administrador);
        break;
    case 4:
        System.Console.WriteLine("Digite o Id do Administrador a ser deletado:");
        id = Convert.ToInt32(Console.ReadLine());
        administrador = new Administrador(){
            Id = id
        };
        administradorDAO = new AdministradorDAOEF();
        administradorDAO.Deletar(administrador);
        break;
    default:
        break;
}

