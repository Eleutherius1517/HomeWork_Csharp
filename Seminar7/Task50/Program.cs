// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2
int[,] GenerateArray(int rows, int columns)
{
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
int Prompt (string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"a[{i}, {j}] = {array[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}
int FindElemet (int[,] array, int row, int column)
{
    int result = -1;
    if (array.GetLength(0) < row || array.GetLength(1) < column)
    {
        return result;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == row || j == column)
            {
                result = 1;
            }
        }
    }
    return result;
}
int rows = Random.Shared.Next(2, 10);
int columns = Random.Shared.Next(2, 10);
System.Console.WriteLine($"Массив сгенерирован!");

int rowInput = Prompt("Введите первый индекс числа в двумерном массиве - ");
int columnInput = Prompt("Введите первый индекс числа в двумерном массиве - ");

int[,] array = GenerateArray(rows, columns);
int searchResult = FindElemet(array, rowInput, columnInput);

System.Console.WriteLine("Вот наш массив: ");
PrintArray(array);

if (searchResult != 1)
{
    System.Console.WriteLine("Числа с таким индексом в массиве нет!!!");
}
else
{
    System.Console.WriteLine($"Под индексом массива [{rowInput}, {columnInput}] = {array[rowInput, columnInput]} ");
}

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();



