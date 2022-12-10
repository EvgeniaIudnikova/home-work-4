// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите в строку числа через пробел");
string numbers = Console.ReadLine();
int[] num = NewMass(numbers);
Console.Write($"В массиве [{String.Join(", ", num)}] положительных чисел в массиве = {CountPlus(num)}");

//функция принимает строку и переводит ее в массив строк, а затем массив строк переводит в массив целых чисел
int[] NewMass (string m)
{
    string[] now = m.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[now.Length];
    for (int i= 0; i< now.Length; i++)
    {
        array[i] = int.Parse(now[i]);
    }
return array;
}

//фу-ция считающая кол-во положительных элементов в массиве 
int CountPlus (int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el > 0 )
        {
            count++;  
        }
    }
return count;
}