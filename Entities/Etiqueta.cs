namespace efept.Entities
{
    public class Etiqueta
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public List<EtiquetaPost>? Posts { get; set; }
        public List<EtiquetaLibro>? Libros { get; set; }
    }
}
