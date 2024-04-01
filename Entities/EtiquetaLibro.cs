namespace efept.Entities
{
    public class EtiquetaLibro
    {
        public int Id { get; set; }
        public int IdEtiqueta { get; set; }
        public int IdLibro { get; set; }
        public required Etiqueta Etiqueta { get; set; }
        public required Libro Libro { get; set; }
    }
}
