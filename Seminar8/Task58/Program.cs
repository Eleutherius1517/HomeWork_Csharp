// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

int[,] GenerateArray()
{
    int rows = Random.Shared.Next(2, 3);
    int columns = Random.Shared.Next(2, 3);
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
int[,] GetMultiMatrix(int[,] matrix1, int[,] matrix2)
{
    int rows = matrix1.GetLength(0);
    int columns = matrix1.GetLength(1);
    int rowsForSumm = matrix2.GetLength(0);
    int[,] multiMatrix = new int [rows, columns];
    System.Console.WriteLine("\n Перемножим матрицы: ");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           for (int k = 0; k < rowsForSumm; k++)
           {
                multiMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                
           }
           System.Console.WriteLine($"multiMatrix[{i}, {j}] = {multiMatrix[i, j]} ");

        }
        
    }
    return multiMatrix;
    
}

System.Console.WriteLine("\n Первая матрица: ");
int[,] matrix1 = GenerateArray();
PrintArray(matrix1);
System.Console.WriteLine("\n Вторая матрица: ");
int[,] matrix2 = GenerateArray();
PrintArray(matrix2);

int[,] multiMatrix = GetMultiMatrix(matrix1, matrix2);
System.Console.WriteLine("\n Вот перемноженная матрица: ");
PrintArray(multiMatrix);



Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadKey();