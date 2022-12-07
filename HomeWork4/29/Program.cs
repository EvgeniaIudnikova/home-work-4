// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

PrintArray(GetArray(8));

int[] GetArray(int size)
{
    int[] collection = new int [size];
    for (int i = 0; i < size; i++)
    {
        collection[i] = new Random().Next(0, 100);
    }
    return collection;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}