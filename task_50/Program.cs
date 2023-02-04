// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7(ввод индексов) -> такого числа в массиве нет
// 1, 1 -> 9

Console.Write ("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [m, n];
FillArrayWithRandom(matrix, m, n);

Console.Write ("Введите индекс i: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите индекс j: ");
int j = Convert.ToInt32(Console.ReadLine());

if (i<m && j<n)
{
    Console.WriteLine("Данным индексам соответствует число: " + matrix[i, j]);
}
else 
{
    Console.WriteLine("Такого числа в массиве нет");
}

void FillArrayWithRandom (int [,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = i + j;
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}