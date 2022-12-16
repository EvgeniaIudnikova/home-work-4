// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int m = int.Parse(Console.ReadLine());
int[,] array = new int[n, m];
int[,] matrix =  GetSpire(array);
PrintArray(matrix);
Console.WriteLine();

int[,] GetSpire (int[,] array)
{
    int[,] matrix = new int[n, m];
    int row = 0;
    int columns = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = m;
 
    for (int i = 0; i < matrix.Length; i++) 
    {
        matrix[row, columns] = i + 1;
        if (--visits == 0) 
        {
            visits = m * (dirChanges %2) + n * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }

        columns += dx;
        row += dy;
    }
    return matrix;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

