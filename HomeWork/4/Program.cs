// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int B = 1;

while (B<=N)
{
    if (B%2 == 0)
    {
    Console.Write($"{B} ");
    }
    B++;
}
