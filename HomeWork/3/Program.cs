// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num%2 == 1)
    Console.WriteLine($"Число{num} - не четное");
else
{
    Console.WriteLine($"Число{num} - четное");
}

