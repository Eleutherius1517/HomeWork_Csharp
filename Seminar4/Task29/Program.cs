// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int Prompt (string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int[] GenerateArray(int lenght, int minValue, int maxValue)
{
    int[] array = new int[lenght];
    Random random = new Random();
    for (int i = 0; i < lenght; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}
int lenght = Prompt("Длинна массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значение для диапазона случайного числа: ");
int[] array = GenerateArray(lenght, min, max);
PrintArray(array);
