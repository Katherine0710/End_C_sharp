// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Двоичное число: " + Des(a));

string Des (int a)
{
    string me = "";
    while (a != 0)
    {
        me += a%2;
        a = a/2;
    }

    char[] arr = me.ToCharArray();
    Array.Reverse(arr);

    return new String(arr);
}

// void GetBinaryView(int number)
// {
// if(number == 0) return;
// GetBinaryView(number/2);
// Console.Write(number%2);
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// GetBinaryView(number);