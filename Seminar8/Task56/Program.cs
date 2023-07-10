// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GenerateArray()
{
    int rows = Random.Shared.Next(3, 7);
    int columns = Random.Shared.Next(3, 7);
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Random.Shared.Next(0, 100);
        }
        
    }
    return array;
}
void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int GetMinRow(int[,] array)
{
    int min = 0;
    int temp = 0;
    int indexRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i,j];
        }
        System.Console.WriteLine(temp);
        if (min == 0 || min > temp)
        {
            min = temp;
            indexRow = i;
        }
        temp = 0;

    }
    return indexRow + 1;
    
}

int[,] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Сумма элементов в строках: ");
int indexMin = GetMinRow(array);
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexMin}");


Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();
