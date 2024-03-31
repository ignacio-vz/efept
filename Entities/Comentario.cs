using efept.Data;

namespace efept.Entities
{
    public class Comentario
    {
        public int Id { get; set; }
        public int IdPost { get; set; }
        public int IdUsuario { get; set; }
        public required string Texto { get; set; }
        public required Post Post { get; set; }
        public required ApplicationUser Usuario { get; set; }
    }
}
