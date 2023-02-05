// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

void FillArrayWithRandom(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArrayWithRandom(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];
FillArrayWithRandom(matrix);
PrintArrayWithRandom(matrix);
int[,] ResultMatrix = new int[n,m];

for(int i = 0; i < ResultMatrix.GetLength(0); i++) // i < ResultMatrix.GetLength(0) значит, что количество строк меньше чем количество элементов в строке в результирующей матрице, а количество элементов в строке в результирующей матрице равно количеству столбцов в первой матрице.
{
    for(int j = 0; j < ResultMatrix.GetLength(1); j++) // j < ResultMatrix.GetLength(0) значит, что количество столбцов меньше чем количество элементов в столбце в результирующей матрице, а количество элементов в столбце в результирующей матрице равно количеству строк в первой матрице.
    {
        ResultMatrix[i,j] = matrix[j, i]; // компуктер воспринимает не i и j, а 0, 1, 2... И когда мы прописываем matrix [j, i], то имеем в виду matrix [1,0], что соответствует строке 2 (индекс 1), столбцу 1 (индекс 0)
    }
}
Console.WriteLine();
PrintArrayWithRandom(ResultMatrix);