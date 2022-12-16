// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
//
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите z: ");
int z = int.Parse(Console.ReadLine());
int[,,] matrix = GetArray(x, y, z);
PrintArray(matrix);
Console.WriteLine();

int[,,] GetArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    int a = 10;
    for (int i = 0; i < x ; i++)
    {    
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = a;
                a++;
            }                                       
        }
    }
    return array;        
}

//Чтобы сделать массив из неповторяющихся рандомных значений возможно потребуется что-то думать с следующими строками
//но у меня никак не получается
// foreach (int el in array) 
//     if (array[a, b, c]==el && (i != a || j != b || k != c))
//     array[a, b, c] = new Random().Next(min, max + 1);


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

