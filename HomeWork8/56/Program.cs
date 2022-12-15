// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] matrix = GetArray(rows, columns, -10, 10);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine(String.Join(" ", SumElementRows(matrix)));
FindMin(SumElementRows(matrix));


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


int[] SumElementRows (int[,] array)
{
    int[] sumEl = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++) 
    {   
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            if (j == array.GetLength(1)-1)
            sumEl[i] = sum;
        }
    }
    return sumEl;
}


//поиск минимального элемента и вывод его индекса
void FindMin(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;  
        } 
    }
    Console.Write($"Индекс строки с минимальной суммой элементов = {index}");        
}