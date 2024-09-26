using MySql.Data.MySqlClient;

public class AdministradorDAO
{
    public void Adicionar(Administrador administrador) {
        try
        {
            MySqlConnection conexao = new Conexao().Criar();
            conexao.Open();

            string sql = "INSERT INTO Administrador (nomeUsuario, " + 
                "email, senha, status, foto) VALUES (\"Maria\", \"" +
                "maria@mail.com\",\"pwd\",1,\"fotoJoao\")";
            
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.ExecuteNonQuery();

            
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}