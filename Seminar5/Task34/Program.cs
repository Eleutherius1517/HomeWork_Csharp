// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] GenerateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Random.Shared.Next(100, 1000);
    }
    return array;
}
int GetEvenNumbers(int[] array)
{
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenCount += 1;
        }
    }
    return evenCount;
}
Console.Write("Это Задача №34 \nВведите длинну массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = GenerateArray(lenght);
int evenCount = GetEvenNumbers(array);
Console.WriteLine($"Массив создан: [ {string.Join(", ", array)} ]");
Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();
