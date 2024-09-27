using MySql.Data.MySqlClient;

public class AdministradorDAO {
    public void Adicionar(Administrador administrador) {

        try {
            MySqlConnection conexao = new Conexao().Criar();
            conexao.Open();

            string sql = "INSERT INTO Administrador(nomeUsuario, email, senha, status, foto) VALUES" + 
            "(@nomeUsuario, @email, @senha, @status, @foto)";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nomeUsuario", administrador.NomeUsuario);
            comando.Parameters.AddWithValue("@email", administrador.Email);
            comando.Parameters.AddWithValue("@senha", administrador.Senha);
            comando.Parameters.AddWithValue("@status", administrador.Status);
            comando.Parameters.AddWithValue("@foto", administrador.Foto);
            comando.ExecuteNonQuery();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            throw;
        }
    }
    public List<Administrador> ListarTodos() {
        try {
            List<Administrador> administradores = new List<Administrador>();
            MySqlConnection conexao = new Conexao().Criar();
            conexao.Open();

            string sql = "SELECT * FROM Administrador";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader leitor = comando.ExecuteReader();

            while (leitor.Read()) {
                Administrador administrador = new Administrador(){
                    NomeUsuario = Convert.ToString(leitor["nomeUsuario"]),
                    Email = Convert.ToString(leitor["email"]),
                    Senha = Convert.ToString(leitor["senha"]),
                    Status = Convert.ToInt32(leitor["status"]),
                    Foto = Convert.ToString(leitor["foto"])
                };
                administradores.Add(administrador);
            }

            return administradores;
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}