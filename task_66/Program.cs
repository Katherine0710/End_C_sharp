// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write ("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;

Console.WriteLine ();
PrintNumber (M, N);
Console.WriteLine ();

if (M < N)
{
    Console.WriteLine ();
    Console.WriteLine ("Сумма элементов: " + sum);
    Console.WriteLine ();
}

void PrintNumber (int number1, int number2)
{
    if (number1 == number2+1)
    {
        return;
    }

    if (number1 > number2)
    {
        Console.WriteLine ();
        Console.Write ("Введите число M меньшее, чем N");
        Console.WriteLine ();
        return;
    }
    Console.Write (number1 + " ");
    sum = sum + number1;
    number1 = number1 + 1;
    PrintNumber (number1, number2);
}