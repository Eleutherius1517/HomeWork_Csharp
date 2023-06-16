// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите Ваше число: ");
int numberIn = Convert.ToInt32(Console.ReadLine());
int countDecimal = 1; //это счетчик десятков, т.е цифр, он равен 1 потому что это минимальное его значение,
                      // и оно не учитывается в условии цикла (numberIn / 10 != 0)
int tempNum = numberIn;
while(tempNum / 10 != 0)
{
    tempNum = tempNum / 10;
    countDecimal++;
}
int div = (int)Math. Pow(10, countDecimal - 3);// можно посчитать через цикл, но так быстрее
int thirdDigit = (numberIn / div) % 10;
Console.WriteLine($"\nТретья цифра в Вашем числе: {thirdDigit}");

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();

