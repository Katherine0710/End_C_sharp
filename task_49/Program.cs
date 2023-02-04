// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 49 2
// 5 9 2 3
// 64 4 4 4

Console.Write ("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [m, n];
FillArrayWithRandom(matrix, m, n);
Console.WriteLine();
FillArraySqrt (matrix, m, n);


void FillArrayWithRandom (int [,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArraySqrt (int [,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i%2==0 && j%2==0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
                Console.Write(matrix[i, j] + " ");
            }
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}