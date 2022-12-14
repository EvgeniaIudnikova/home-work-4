// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Clear();
Console.Write("количество строк m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("количество столбцов n = ");
int n = int.Parse(Console.ReadLine());
double[,] doubleArray = GetArrayDoudleNumber(m, n);
PrintArray(doubleArray);


double[,] GetArrayDoudleNumber(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble()* 100-30;
        }
    }
    return array;
}


void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f3}   ");
        }
        Console.WriteLine();
    }
}