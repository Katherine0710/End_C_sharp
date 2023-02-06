// Задача 63. Найдите значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Write ("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintNumber (M, N);

void PrintNumber (int number1, int number2)
{
    if (number1 == number2+1)
    {
        return;
    }
    if (number1>=number2)
    {
        Console.Write ("Введите число M меньшее, чем N");
        return;
    }
    Console.Write (number1 + " ");
    number1 = number1 + 1;
    PrintNumber (number1, number2);
}