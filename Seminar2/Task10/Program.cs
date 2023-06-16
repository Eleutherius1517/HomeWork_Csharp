// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int numberIn = Convert.ToInt32(Console.ReadLine());

if(numberIn > 999 || numberIn < 100)
{
    Console.Write("Вы ввели не корректное число!");
}
else 
{
    int numSecond = (numberIn / 10) % 10;
    Console.Write($"Вторая цифра вашего числа: {numSecond}!");
}

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();
