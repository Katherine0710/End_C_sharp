// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write ("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [m, n];
FillArrayWithRandom(matrix, m, n);
Console.WriteLine();

void FillArrayWithRandom (int [,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int sum = 0;
int i = 0;
int j =0;

while (i<m && j<n)
{
    if(i==j)
    {
        sum = sum + matrix[i, j];
    }
    i++;
    j++;
}
Console.WriteLine("Сумма по главной диагонали = " + sum);