using System;

namespace PruebaPractica
{
    class Program
    {
        static void Main()
        {
            int mayoresM1 = 0;
            int mayoresM2 = 0;
            int iguales = 0;
            
            int[,] matriz1 =
            {
                {17, 9, 36},
                {8, 7, 2},
                {15, 28, 87}
            };

            int[,] matriz2 =
            {
                {9, 21, 36},
                {16, 65, 4},
                {12, 28, 31}
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz1[i,j] == matriz2[i,j])
                    {
                        iguales +=1;
                    }
                    else if (matriz1[i,j] > matriz2[i,j])
                    {
                        mayoresM1 += 1;
                    }
                    else
                    {
                        mayoresM2 += 1;
                    }
                }
            }

            Console.WriteLine($"\nEl arreglo 1 contiene {mayoresM1} elementos mayores.\n");
            Console.WriteLine($"El arreglo 2 contiene {mayoresM2} elementos mayores.\n");
            Console.WriteLine($"Existen {iguales} elementos iguales en ambos arreglos.\n");
        }
    }
}
