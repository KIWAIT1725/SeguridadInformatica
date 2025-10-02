using System;

namespace CifradoCesar
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n=== CIFRADO CÉSAR ===");
                Console.WriteLine("1. Encriptar");
                Console.WriteLine("2. Desencriptar");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "3")
                {
                    Console.WriteLine("Saliendo del programa...");
                    break;
                }

                Console.Write("\nIngrese el mensaje: ");
                string mensaje = Console.ReadLine();

                Console.Write("Ingrese la clave numérica: ");
                if (!int.TryParse(Console.ReadLine(), out int clave))
                {
                    Console.WriteLine("Clave inválida. Intente nuevamente.");
                    continue;
                }

                switch (opcion)
                {
                    case "1":
                        string cifrado = Encriptador.Encriptar(mensaje, clave);
                        Console.WriteLine($"\nMensaje encriptado: {cifrado}");
                        break;

                    case "2":
                        string descifrado = Desencriptador.Desencriptar(mensaje, clave);
                        Console.WriteLine($"\nMensaje desencriptado: {descifrado}");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}
