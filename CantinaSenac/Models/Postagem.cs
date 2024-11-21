public abstract class Postagem {
    public int Id { get; set; }
    public string Conteudo { get; set; }
    public string DataPublicacao { get; set; }
    public string NomeUsuario { get; set; }
    public List<Comentario> Comentarios { get; set; }    
}