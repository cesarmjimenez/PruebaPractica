using System;

namespace PruebaPractica
{
    class OrdenyMediana
    {
        static void Main()
        {
            List<int> números = [];
            int mediana = 0;
            int n = 0;


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
                    números.Add(arreglo[i,j]);
                }
            }

            números.Sort();

            n = números.Count;
            mediana = números[n/2];


            Console.WriteLine($"\nElementos ordenados: {string.Join(", ", números)}\n");
            Console.WriteLine($"Mediana: {mediana}\n");
        }
    }
}