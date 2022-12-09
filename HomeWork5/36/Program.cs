// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] block = PrintArray(7, -10, 100);
Console.WriteLine($"[{String.Join(",", block)}] -> {SumElement(block)}");

//ф-ция заполнения массива
int[] PrintArray (int size, int min, int max)
{
    int[] array = new int [size];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

//ф-ция подсчета суммы элементов, стоящих на нечетных позициях
int SumElement (int[] array)
{
    int sum = 0;
    for (int i = 1; i<block.Length; i++)
    {   
        if (i%2 == 1)
        {
          sum += block[i];
        }
    }
    return sum;
}