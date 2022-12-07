// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"{A} в {B} степени = {MetodPow(A, B)}");

int MetodPow (int number1, int number2)
{
    int count = 1;
    int Multi = 1;
    while (count <= B)
    {
        Multi *= A;
        count++;
    }
    return Multi;
}
