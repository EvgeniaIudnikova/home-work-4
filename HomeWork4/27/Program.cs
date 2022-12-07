// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 9012 -> 12

Console.Clear();
int num = new Random().Next(0, 100000);
Console.Write($"{num}->{SumNum(num)}");

int SumNum (int number)
{
    int sum = 0;
    while (num >= 1)
    {
        int i = num%10;
        sum += i;
        num /= 10;
    }
    return sum;
}