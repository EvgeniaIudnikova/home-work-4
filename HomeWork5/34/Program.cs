// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = RandomArray(size, 100, 1000);
Console.WriteLine($"[{String.Join(",", array)} -> {CountChet(array)}]");

//ф-ция заполнения массива
int[] RandomArray (int size, int min, int max)
{
int[] array = new int [size];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(min, max); 
}
return array;
}

//ф-ция подсчета четных чисел в массиве
int CountChet (int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el% 2 == 0)
        count++;
    }
    return count;
}