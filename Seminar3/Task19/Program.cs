// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет  12345
// 12821 -> да
// 23432 -> да
Console.Write("Введите пятизначное число: ");
int numberIn = Convert.ToInt32(Console.ReadLine());

int num1 = numberIn / 10000;
int num2 = (numberIn / 1000) % 10;
int num3 = (numberIn / 100) % 10;
int num4 = (numberIn / 10) % 10;
int num5 = numberIn  % 10;

Console.WriteLine($"{num1}, {num2}, {num3}, {num4}, {num5}.");

if(num1 == num5 && num2 == num4)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();
