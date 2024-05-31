namespace efept.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string? Cita { get; set; }
        public string? Categoria { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Imagen { get; set; }
        public string? Texto { get; set; }
        public int Puntuacion { get; set; }
        public List<Comentario>? Comentarios { get; set; }
        public List<EtiquetaPost>? Etiquetas { get; set; }
    }
}
