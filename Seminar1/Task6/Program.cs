// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if(numberN % 2 == 0)
{
    Console.WriteLine($"Число {numberN} четное!");
}
else
{
    Console.WriteLine($"Число {numberN}  НЕчетное!");
}
Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();
