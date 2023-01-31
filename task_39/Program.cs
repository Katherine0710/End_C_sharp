// Напишите программу, которая перевернёт одномерный массив (последний жлемент будет на первом месте, а первый на последнем)
//[1 2 3 4 5] = [5 4 3 2 1]

void FillArrayWithRandom(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(0, 10);
    }
}

void ReverseArray(int[] array)
{
    int temp = 0;
    for (int i = 0; i <array.Length/2; i++)
    {
        temp = array[i];
        array [i] = array [array.Length - 1 - i];
        array [array.Length - 1 - i] = temp;
    }
}

int [] array = new int [5];
FillArrayWithRandom(array);
Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));

ReverseArray(array);
Console.WriteLine("Ваш перевёрнутый массив: ");
Console.WriteLine(string.Join(", ", array));
