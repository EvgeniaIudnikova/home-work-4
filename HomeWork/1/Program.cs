// Задача2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
    Console.WriteLine($"{number1} - большее {number2} - меньшее");
else
{
    Console.WriteLine($"{number1} - меньшее {number2} - большее");
}
