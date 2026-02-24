using System;

namespace PruebaPractica
{
    class SumaDiagonal
    {
        static void Main()
        {
            int suma = 0;

            int[,] arreglo =
            {
              {17, 9, 36, 21},
              {8, 28, 3, 1},
              {15, 7, 5, 30},
              {10, 17, 4, 12} 
            };

            suma = arreglo[0,0] + arreglo[1,1] + arreglo[2,2] + arreglo[3,3];


            Console.WriteLine($"La suma es: {suma}"); 
        }
    }
}