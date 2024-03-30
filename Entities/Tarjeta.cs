namespace efept.Entities
{
    public class Tarjeta
    {
        public int Id { get; set; }
        public required string Titulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Imagen { get; set; }
    }
}
