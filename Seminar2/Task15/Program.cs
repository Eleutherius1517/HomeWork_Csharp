// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int numberIn = Convert.ToInt32(Console.ReadLine());

if(numberIn > 0 && numberIn < 6)
{
    Console.WriteLine("\nНет, этот день недели рабочий!");
}
else if(numberIn >= 6 && numberIn <= 7)
{
    Console.WriteLine("\nДа, этот день недели ВЫХОДНОЙ!");
}
else
{
    Console.WriteLine("\nНекорректный номер дня недели...");
}

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();