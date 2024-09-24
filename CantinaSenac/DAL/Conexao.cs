using MySql.Data.MySqlClient;

public class Conexao {
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenacAdo;Uid=root;Pwd=";

    public MySqlConnection Criar() {
        MySqlConnection conexao;

        try {
            conexao = new MySqlConnection(stringConexao);
            Console.WriteLine("Conexão criada com sucesso");
            return conexao;
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}