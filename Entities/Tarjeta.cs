using efept.Services;

namespace efept.Entities
{
    public class Tarjeta
    {
        public int Id { get; set; }
        private string? _titulo;
        public required string Titulo
        {
            get
            {
                if (_titulo == null)
                {
                    return string.Empty;
                }
                return _titulo;
            }
            set
            {
                _titulo = value;
                TituloNormalizado = NormalizarService.NormalizarTitulo(value);
            }
        }
        public string? TituloNormalizado { get; private set; }
        public string? Descripcion { get; set; }
        public string? Imagen { get; set; }
    }
}
