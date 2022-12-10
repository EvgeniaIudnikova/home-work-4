// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Даны две прямые заданные уравнениями y = k1 * x + b1 ;  y = k2 * x + b2");
Console.WriteLine("Введите значение b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = double.Parse(Console.ReadLine());

Console.WriteLine($"точка пересечения прямых ({String.Join("; " ,ToLine (b1, k1, b2, k2))})");

//Функция высчитывает точку пересечения двух прямых заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2;
double[] ToLine (double B1, double K1, double B2, double K2)
{
double k = k1+k2;
double b = -1*(b1+b2);
double x = b / k;
double y = k1 * x + b1;
double[] coordinates = new double [2];
coordinates [0] = x;
coordinates [1] = y;
return coordinates;
}

//можно без функции просто стр 23 - 26 и ввод следующей стр
//Console.WriteLine($"точка пересечения прямых ({x:f3}; {y:f3})");

