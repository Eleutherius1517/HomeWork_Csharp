// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X первой точки: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int aZ = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X второй точки: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int bZ = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2));
Console.WriteLine($"Растояние между двумя введенными точками: {result:f2}");

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadLine();