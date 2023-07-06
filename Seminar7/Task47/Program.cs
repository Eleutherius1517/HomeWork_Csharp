// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GenerateArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(Random.Shared.Next(-100, 100)/10.0);
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
void PrintArray (double[,] array)
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
int rows = Prompt("Задайте количество строк - ");
int columns = Prompt("Задайте столбцов строк - ");
double[,] array = GenerateArray(rows, columns);
PrintArray(array);

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();

