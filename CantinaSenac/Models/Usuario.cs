public abstract class Usuario {
    public int Id { get; set; }
    public string NomeUsuario { get; set; }
    public string Email { get; set;}
    public string Senha { get; set;}
    public int Status { get; set;}
    public string Foto { get; set;}
    public List<Postagem> Postagems { get; set; }

    /*public Usuario(int id, string nomeUsuario, string email, string senha, int status, string foto) {
        Id = id;
        NomeUsario = nomeUsuario;
        Email = email;
        Senha = senha;
        Status = status;
        Foto = foto;
    }*/
    
    public void Cadastrar() {
    }

    public void Atualizar() {
    }

    public void PublicarFeedback() {
    }

    public void ComentarFeedback() {

    }

    public void LogaR() {
    }
}