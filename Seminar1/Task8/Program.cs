// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
string evenNum = "";
for(int i = 1; i <= numberN; i++)
{
    if(i % 2 == 0)
    {
        string temp = Convert.ToString(i);
        evenNum += temp + " ";
    }
}
Console.Write("Список четных чисел от 1 до " + numberN + ": " + evenNum);
Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();