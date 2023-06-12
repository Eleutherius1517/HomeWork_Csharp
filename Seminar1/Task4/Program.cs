// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число : ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
int[] nums = {firstNumber, secondNumber, thirdNumber};
for(int i = 1; i < 3; i++)
{
    if(nums[i] > max)
    {
        max = nums[i];
    }
}
Console.Write($"Максимальное из этих чисел: {max}. ");
Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();