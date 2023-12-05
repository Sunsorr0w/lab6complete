using System;

class Program
{
    static void Main()
    {
        // Приклад використання класу MathOperations

        // Додавання чисел
        int sumInt = MathOperations.Add(5, 10);
        Console.WriteLine("Sum of integers: " + sumInt);

        double sumDouble = MathOperations.Add(3.5, 7.2);
        Console.WriteLine("Sum of doubles: " + sumDouble);

        // Додавання масивів
        int[] arrayA = { 1, 2, 3 };
        int[] arrayB = { 4, 5, 6 };

        int[] sumArray = MathOperations.Add(arrayA, arrayB);
        Console.WriteLine("Sum of arrays: " + string.Join(", ", sumArray));

        // Додавання матриць
        int[,] matrixA = { { 1, 2 }, { 3, 4 } };
        int[,] matrixB = { { 5, 6 }, { 7, 8 } };

        int[,] sumMatrix = MathOperations.Add(matrixA, matrixB);
        Console.WriteLine("Sum of matrices:");
        PrintMatrix(sumMatrix);

        Console.ReadLine(); // Pause to see the output
    }

    // Вспоміжний метод для виведення матриці на екран
    static void PrintMatrix<T>(T[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

