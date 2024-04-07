namespace efept.Services
{
    public class NormalizarService
    {
        public static string NormalizarTitulo(string titulo)
        {
            return titulo.Replace("Á", "A").Replace("É", "E")
                         .Replace("Í", "I").Replace("Ó", "O")
                         .Replace("Ú", "U").Replace("Ü", "U")
                         .Replace("Ñ", "N").Replace(" ", "-").ToLower();
        }
    }
}
