// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int Prompt (string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int[] InputArray(int lenght)
{
    int[] array = new int[lenght];
    
    for (int i = 0; i < lenght; i++)
    {
        array[i] = Prompt($"Введите {i + 1}-й элемент массива: ");
    }
    return array;
}
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]} ");
    }
}
int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int lenght = Prompt("Введите количество элементлов > ");
int[] array = InputArray(lenght);
PrintArray(array);
System.Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();