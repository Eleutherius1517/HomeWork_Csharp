// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
bool compNum = firstNumber>secondNumber;
if(firstNumber>secondNumber)
{
    Console.WriteLine($"\nПервое число большеe: {firstNumber}. Второе число меньшеe: {secondNumber} ." );

}
else if(secondNumber>firstNumber)
{
    Console.WriteLine($"\nВторое число большеe: {secondNumber}. Первое число меньшеe: {firstNumber}." );
}
else
{
    Console.WriteLine("\nЧИСЛА РАВНЫ!!!");
}
Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();
