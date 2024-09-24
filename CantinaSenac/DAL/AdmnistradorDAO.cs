using MySql.Data.MySqlClient;

public class AdmnistradorDAO {
    public void Adicionar(Administrador administrador) {
        try {
            MySqlConnection conexao = new Conexao().Criar();
            conexao.Open();

            string sql = "INSERT INTO Administrador(nomeUsuario," + "email, senha, status, foto) VALUES(\"Joao\", \"" + "joao@mail.com\", \"pwd\", 1, \"fotodoJoao\")";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.ExecuteNonQuery();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}