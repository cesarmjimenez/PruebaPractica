using System;

namespace PruebaPractica
{
    class InverseString
    {
        static void Main()
        {
            Console.WriteLine("Ingrese una cadena de texto para invertirla.");
            string? texto = Console.ReadLine();

            char[] caracteres = texto!.ToCharArray();

            Array.Reverse(caracteres);

            string inverso = new(caracteres);

            Console.WriteLine($"El texto invertido de {texto} es: {inverso}");
        }
    }
}