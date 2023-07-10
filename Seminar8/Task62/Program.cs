// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GenerateSpiralArray()
{
    int n =4;
    var spiralArray = new int[n, n];
    int valueNumber = 0;
            for (int  countIndex = 0; countIndex < n/2; countIndex++)
            {
                for (int j = countIndex; j < n - countIndex; j++)
                {
                    spiralArray[countIndex, j] = ++valueNumber;
                }
                for (int i = countIndex + 1; i < n - countIndex - 1; i++)
                {
                    spiralArray[i, n - countIndex - 1] = ++valueNumber;
                }

                for (int j = n - countIndex - 1; j >= countIndex; j--)
                {
                    spiralArray[n - countIndex - 1, j] = ++valueNumber;
                }
                   
                for (int i = n - countIndex - 2; i >= countIndex +1 ; i--)
                {
                    spiralArray[i, countIndex] = ++valueNumber;
                }  
            }
            if (n%2 != 0 && spiralArray[0, 0] == 1)
                spiralArray[n/2, n/2] = 1;
            return spiralArray;
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
int[,] spiralArray = GenerateSpiralArray();
System.Console.WriteLine("Вот наш массив заполненный спирально: ");
PrintArray(spiralArray);

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadKey();