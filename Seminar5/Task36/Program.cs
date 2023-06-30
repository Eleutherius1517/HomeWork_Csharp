// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] GenerateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Random.Shared.Next(0, 1000);
    }
    return array;
}
int GetSumElements(int[] array)
{
    int sumElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumElements += array[i];
        }
    }
    return sumElements;
}

Console.Write("Это Задача №36 \nВведите длинну массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = GenerateArray(lenght);
int sumElements = GetSumElements(array);

Console.WriteLine($"Массив создан: [ {string.Join(", ", array)} ]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях массива: {sumElements}");

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();