using efept.Data;

namespace efept.Entities
{
    public class Puntuacion
    {
        public int Id { get; set; }
        public required string IdUsuario { get; set; }
        public int IdPost { get; set; }
        public int Puntos { get; set; }
        public required ApplicationUser Usuario { get; set; }
        public required Post Post { get; set; }
    }
}
