// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// M = 5 -> "5, 4, 3, 2, 1"
// M = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine(PrintNumbers(M));

string PrintNumbers(int M)
{
    if (M == 1)
        return "1";
    return ( M.ToString() + ' ' + PrintNumbers(M - 1));    
}