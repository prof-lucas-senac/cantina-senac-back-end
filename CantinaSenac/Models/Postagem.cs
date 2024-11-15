public abstract class Postagem {
    public int Id { get; set; }
    public string Conteudo { get; set; }
    public string DataPublicacao { get; set; }
        //DateTime
    public string NomeUsuario { get; set; }
        //Usuario  Usuario
    public List<Comentario> Comentarios { get; set; }
}