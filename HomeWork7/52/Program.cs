// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.Write($"{AverageColumns (array)}");




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

string AverageColumns (int[,] matrix)
{
    string avrgVerticall = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++) 
    {   
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
           sum += array[i, j];
           if (i == array.GetLength(0)-1)
           {
                double avrg = (sum/array.GetLength(0));
                avrgVerticall = avrgVerticall + avrg + "; ";  
           }
        }  
    }
return avrgVerticall;
} 