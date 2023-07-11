// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt (string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
void GetAllPositiveNum (int number)
{
    if (number == 0) return;
    System.Console.Write(number + " ");
    GetAllPositiveNum(number - 1);
}
int number = Prompt("Введите число N > ");
GetAllPositiveNum (number);

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadKey();