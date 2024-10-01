using MySql.Data.MySqlClient;

public class AdministradorDAO
{
    public void Adicionar(Administrador administrador) {
        try
        {
            MySqlConnection conexao = new Conexao().Criar();
            conexao.Open();

            string sql = "INSERT INTO Administrador (nomeUsuario, " + 
                "email, senha, status, foto) VALUES " + 
                "(@nomeUsuario, @email, @senha, @status, @foto)";
            
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nomeUsuario", administrador.NomeDoUsuario);
            comando.Parameters.AddWithValue("@email", administrador.Email);
            comando.Parameters.AddWithValue("@senha", administrador.Senha);
            comando.Parameters.AddWithValue("@status", administrador.Status);
            comando.Parameters.AddWithValue("@foto", administrador.Foto);
            comando.ExecuteNonQuery();
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
    public List<Administrador> ListarTodos() {
        try
        {
            List<Administrador> administradores = new List<Administrador>();
            MySqlConnection conexao = new Conexao().Criar();
            conexao.Open();

            string sql = "select * from Administrador";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader leitor = comando.ExecuteReader();

            while(leitor.Read()){
                Administrador administrador = new Administrador(){
                    NomeDoUsuario = Convert.ToString(leitor["nomeUsuario"]),
                    Email = Convert.ToString(leitor["email"]),
                    Senha = Convert.ToString(leitor["senha"]),
                    Foto = Convert.ToString(leitor["foto"]),
                    Status = Convert.ToInt32(leitor["status"])
                };
                administradores.Add(administrador);
            }

            return administradores;
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
            return null;
        }
    }
    public void Atualizar(Administrador administrador){
        try
        {
            MySqlConnection conexao = new Conexao().Criar();
            conexao.Open();

            string sql = "UPDATE Administrador SET nomeUsuario = @nomeUsuario, "+
                         "email = @email, senha = @senha, status = @status, " +
                         "foto = @foto WHERE id = @id;";
            
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nomeUsuario", administrador.NomeDoUsuario);
            comando.Parameters.AddWithValue("@email", administrador.Email);
            comando.Parameters.AddWithValue("@senha", administrador.Senha);
            comando.Parameters.AddWithValue("@status", administrador.Status);
            comando.Parameters.AddWithValue("@foto", administrador.Foto);
            comando.Parameters.AddWithValue("@id", administrador.Id);

            comando.ExecuteNonQuery();
            System.Console.WriteLine("Administrador atualizado com sucesso");
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
    public void Deletar(Administrador administrador){
        try
        {
            MySqlConnection conexao = new Conexao().Criar();
            conexao.Open();

            string sql = "DELETE FROM Administrador WHERE id = @id;";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", administrador.Id);

            comando.ExecuteNonQuery();
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}