// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите индекс строки: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(5, 7, 0, 10);
PrintArray(array);
FindElementArray (rows, columns, array);


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindElementArray (int x, int y, int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i==x && j == y)
               Console.Write($"{array[i, j]} - элемент имеющий позицию [{x}, {y}]");
            else
            {
                Console.WriteLine($"Элемента с такой позицией [{x}, {y}] нет");
                return;
            }
        }     
    }
}

