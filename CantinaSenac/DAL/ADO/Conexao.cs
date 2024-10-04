using MySql.Data.MySqlClient;

public class Conexao
{
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenacAdo;Uid=root;Pwd=root;";

    public MySqlConnection Criar() {
        MySqlConnection conexao;
        try
        {
            conexao = new MySqlConnection(stringConexao);
            System.Console.WriteLine("Conexão criada com sucesso.");
            return conexao;
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
            throw;
        }
    }
}