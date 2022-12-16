// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите z: ");
int z = int.Parse(Console.ReadLine());
int[,,] matrix = GetArray(x, y, z, 10, 100);
PrintArray(matrix);
Console.WriteLine();

int[,,] GetArray(int x, int y, int z, int min, int max)
{
    int[,,] array = new int[x, y, z];
    for (int i = 0; i < x ; i++)
    {    
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = new Random().Next(min, max + 1);
            }                                       
        }
    }
    return array;        
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} [{i}, {j}, {k}]   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

