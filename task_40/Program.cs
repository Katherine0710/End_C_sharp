// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

//Например: 3, 4, 5
    // 3 + 4 > 5
    // 4 + 5 > 3
    // 3 + 5 > 4
// Треугольник со сторонами 3, 4 и 29 - существовать не может

void Dlina (int[] array)
{
    if (array[0]+array[1]>array[2] && array[0]+array[2]>array[1] && array[1]+array[2]>array[0]) 
    {
        Console.WriteLine ("Треугольник существует");
    }
    else 
    {
        Console.WriteLine ("Такой треугольник не существует");
    }
}

Console.Write("Введите сторону 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите сторону 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите сторону 3: ");
int c = Convert.ToInt32(Console.ReadLine());

int [] array = new int [3];
array[0] = a;
array[1] = b;
array[2] = c;

Dlina (array);

