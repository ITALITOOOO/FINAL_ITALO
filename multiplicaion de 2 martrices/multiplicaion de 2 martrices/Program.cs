// See https://aka.ms/new-console-template for more informationusing System;

using System;

class MatrixMultiplication
{
    static void Main()
    {
        
        Console.Write("Ingrese el tamanio de las matrices: ");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix1 = new int[size, size];
        int[,] matrix2 = new int[size, size];
        int[,] resultMatrix = new int[size, size];
        Console.WriteLine("Ingrese los valores para la primera matriz:");
        for (int i = 0; i < size; i++)
        {
            string[] row = Console.ReadLine().Split(' ');
            for (int j = 0; j < size; j++)
            {
                matrix1[i, j] = int.Parse(row[j]);
            }
        }
        
        Console.WriteLine("Ingrese los valores para la segunda matriz:");
        for (int i = 0; i < size; i++)
        {
            string[] row = Console.ReadLine().Split(' ');
            for (int j = 0; j < size; j++)
            {
                matrix2[i, j] = int.Parse(row[j]);
            }
        }
        
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < size; k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        Console.WriteLine("Matriz resultante:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}