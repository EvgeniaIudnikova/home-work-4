// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату X: ");
double X = double.Parse(Console.ReadLine());
Console.Write("Введите координату Y: ");
double Y = double.Parse(Console.ReadLine());
Console.Write("Введите координату Z: ");
double Z = double.Parse(Console.ReadLine());
Console.Write("Введите координату X1: ");
double X1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Y1: ");
double Y1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Z1: ");
double Z1 = double.Parse(Console.ReadLine());
double resalt = Math.Sqrt(Math.Pow((X1-X), 2) + Math.Pow((Y1-Y), 2) + Math.Pow((Z1-Z), 2));
Console.WriteLine($"расстояние между точками = {resalt:f2}");