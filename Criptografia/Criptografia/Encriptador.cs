namespace CifradoCesar
{
    public static class Encriptador
    {
        public static string Encriptar(string texto, int clave)
        {
            if (string.IsNullOrEmpty(texto))
                return string.Empty;

            char[] resultado = new char[texto.Length];

            for (int i = 0; i < texto.Length; i++)
                resultado[i] = CifrarCaracter(texto[i], clave);

            return new string(resultado);
        }

        private static char CifrarCaracter(char caracter, int clave)
        {
            if (!char.IsLetter(caracter))
                return caracter;

            char baseAscii = char.IsUpper(caracter) ? 'A' : 'a';
            int posicion = (caracter - baseAscii + clave) % 26;

            if (posicion < 0)
                posicion += 26;

            return (char)(baseAscii + posicion);
        }
    }
}
