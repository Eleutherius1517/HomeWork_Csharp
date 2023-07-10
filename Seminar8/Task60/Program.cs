// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GenerateArray()
{
    int rows = Random.Shared.Next(3, 7);
    int columns = Random.Shared.Next(3, 7);
    int tabs = Random.Shared.Next(3, 7);
    int[,,] array = new int[rows, columns, tabs];
    int temp = Random.Shared.Next(10, 20);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (i == 0 && j == 0 && k == 0)
                {
                    array[i, j, k] = temp;
                }
                else
                {
                    array[i, j, k] = temp + 1;
                    temp++;
                }
                
            }
        }
        
    }
    return array;
}
void PrintArray (int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine($"|rows{i}|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"|||columns{j}|\t");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k})\t");
            }
            System.Console.WriteLine($"|columns{j}|||");
        }
        System.Console.WriteLine();
    }
}

int[,,] array = GenerateArray();
PrintArray(array);

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadKey();