// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Write("Введите количество строк в первом массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в первом массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов во втором массиве: ");
int n = int.Parse(Console.ReadLine());
int[,] matrixFerst = GetArray(rows, columns, 0, 10);
PrintArray(matrixFerst);
Console.WriteLine();
int[,] matrixSecond = GetArray(columns, n, 0, 10);
PrintArray(matrixSecond);
Console.WriteLine();
int[,] matrixResult = MultiMatrix (matrixFerst, matrixSecond);
PrintArray(matrixResult);



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


//умножение матриц и создание третьей матрицы как результата умножения
int[,] MultiMatrix (int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrixResult[i, j] = 0;
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
                int multi = matrix1[i, k] * matrix2[k, j];
                matrixResult[i, j] += multi;
            }
        }
    }
    return matrixResult;
}
