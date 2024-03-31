namespace efept.Entities
{
    public class EtiquetaPost
    {
        public int IdEtiqueta { get; set; }
        public int IdPost { get; set; }
        public required Etiqueta Etiqueta { get; set; }
        public required Post Post { get; set; }
    }
}
