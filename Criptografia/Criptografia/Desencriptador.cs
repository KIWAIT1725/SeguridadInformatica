namespace CifradoCesar
{
    public static class Desencriptador
    {
        public static string Desencriptar(string texto, int clave)
        {
            return Encriptador.Encriptar(texto, -clave);
        }
    }
}
