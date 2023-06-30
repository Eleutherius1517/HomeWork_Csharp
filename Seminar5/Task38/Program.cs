// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double[] GenerateArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Random.Shared.Next(0, 1000);
    }
    return array;
}
double GetMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double GetMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

Console.Write("Это Задача №38 \nВведите длинну массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
double[] array = GenerateArray(lenght);

double max = GetMax(array);
double min = GetMin(array);
double result = max - min;

Console.WriteLine($"Массив создан: [ {string.Join(", ", array)} ]");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {result}");

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();