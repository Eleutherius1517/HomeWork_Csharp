// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 9
// m = 2, n = 3 -> A(m,n) = 29
int Prompt (string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int GetAkkermanFunc (int numberM, int numberN)
{
     if (numberM == 0)
     {
        return numberN + 1;
     }
     else if (numberM > 0 && numberN == 0)
     {
        return GetAkkermanFunc(numberM - 1, 1);
     }
     else if (numberM > 0 && numberN > 0)
     {
        return GetAkkermanFunc(numberM - 1, GetAkkermanFunc(numberM, numberN -1));
     }
     
     return -1;
}

int numberM = Prompt("Введите число m > ");
int numberN = Prompt("Введите число n > ");
int akkermanNums = GetAkkermanFunc (numberM, numberN);

System.Console.WriteLine(akkermanNums);

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadKey();