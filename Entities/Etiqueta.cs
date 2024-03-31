namespace efept.Entities
{
    public class Etiqueta
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required List<EtiquetaPost> Posts { get; set; }
    }
}
