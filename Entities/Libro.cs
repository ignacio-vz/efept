namespace efept.Entities
{
    public class Libro
    {
        public int Id { get; set; }
        public required string Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Categoria { get; set; }
        public string? Editorial { get; set; }
        public int? Ano { get; set; }
        public decimal? Precio { get; set; }
        public string? ISBN { get; set; }
        public string? Sinopsis { get; set; }
        public string? Imagen { get; set; }
        public required List<EtiquetaLibro> Etiquetas { get; set; }
    }
}
