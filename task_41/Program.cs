// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int chet = 0;
int positive = 0;
while (true)
{
    Console.WriteLine("Введите число или q чтобы закончить ввод: ");
    int a = 0;
    string? s = "";
    s = Console.ReadLine();
    try { 
        a = Convert.ToInt32(s);
    }
    catch {
        if (s == "q") break;
        Console.WriteLine("Вы ввели не числовое значение. Попробуйте ещё раз.");
    }
    chet += a%2 == 0 ? 1 : 0;
    positive += a>=0 ? 1 : 0;
}

Console.WriteLine("Количество четных: " + chet);
Console.WriteLine("Количество положительных: " + positive);