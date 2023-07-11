// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt (string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int GetSumPositiveNums (int numberM, int numberN)
{
    if (numberM > numberN)
    {
        System.Console.WriteLine("M больше, чем N. Неверные границы диапазона!");
        return -1;
    }
    if (numberM == numberN) return numberN;
    return numberN += GetSumPositiveNums(numberM, numberN - 1);

}
int numberM = Prompt("Введите число M, нижнюю границу диапазона > ");
int numberN = Prompt("Введите число N, верхюю границу диапазона > ");
int sumNums = GetSumPositiveNums (numberM, numberN);

System.Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sumNums}");

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadKey();