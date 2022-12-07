// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да

Console.Clear();
Console.WriteLine("Введите число: ");
string s = Console.ReadLine();
int length = s.Length;
int i = 0;
int j = length-1;
while (i<j)
{
    if (s[i] == s[j])
    {
        i++;
        j = j-1;
    }
    else 
    {
        Console.WriteLine($"число {s} не палиндром");
        return;
    }
}
 Console.WriteLine($"число {s} - палиндром");
