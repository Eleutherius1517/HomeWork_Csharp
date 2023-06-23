// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int numberIn = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Tаблицa кубов чисел от 1 до N:");
for(int i = 1; i <= numberIn; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");
}

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();