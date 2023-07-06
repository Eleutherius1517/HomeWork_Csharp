// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

int[,] GenerateArray()
{
    int rows = Random.Shared.Next(2, 10);
    int columns = Random.Shared.Next(2, 10);
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
void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}
double[] GetAverage (int[,] array)
{
    double summ = 0;
    double[] averageCol = new double [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ += array[j, i];
        }
        averageCol[i] = summ / array.GetLength(0);
        summ = 0;
    }
    return averageCol;
}
int[,] array = GenerateArray();
System.Console.WriteLine("Вот наш массив: ");
PrintArray(array);

double[] averageCol = GetAverage(array);

System.Console.WriteLine("Вот среднее арифметическое каждого столбца: ");
System.Console.WriteLine(string.Join(", ", averageCol));

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();
