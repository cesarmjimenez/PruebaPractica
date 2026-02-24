using System;
using System.Runtime.ConstrainedExecution;

namespace PruebaPractica
{
    class Ejercicio2
    {
        static void Main()
        {
            int promedio = 0;
            int contador = 0;
            int suma = 0;
            List<int> validosSuma = [];
            List<int> noValidosSuma = [];

            int[,] arreglo =
            {
              {17, 9, 36},
              {8, 7, 3},
              {15, 28, 57}  
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    promedio += arreglo[i,j];
                    contador++;
                }
            }

            promedio /= contador;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arreglo[i,j] <= (promedio + (promedio * 0.6)) && arreglo[i,j] >= (promedio - (promedio * 0.6)))
                    {
                        validosSuma.Add(arreglo[i,j]);
                        suma += arreglo[i,j];
                    }
                    else
                    {
                        noValidosSuma.Add(arreglo[i,j]);
                    }
                }
            }

            validosSuma.Sort();
            noValidosSuma.Sort();
            Console.WriteLine($"\nLa suma es: {suma}\n");
            Console.WriteLine($"Promedio: {promedio}\n");
            Console.WriteLine($"No aplican para sumar: {string.Join(", ", noValidosSuma)}\n");
            Console.WriteLine($"Sí aplican para sumar: {string.Join(", ", validosSuma)}\n");
        }
    }
}