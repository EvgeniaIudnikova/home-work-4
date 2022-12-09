// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
 
 Console.Clear();
 double[] matrix = PrintArray(20, -10, 100);
 Console.WriteLine($"{String.Join("| ", matrix)} -> {DiffMaxMin(matrix)}");

//ф-ция заполнения массива
double[] PrintArray (int size, int min, int max)
{
    double[] array = new double [size];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

//ф-ция, высчитывающая разницу между максимальным и минимальным элементов массива
double DiffMaxMin ( double[] array)
{
    double max = array[0];
        for (int i = 0; i< array.Length-1; i++)
    {
        if (max < array[i+1])
        max = array[i+1];
    }

    double min = array[0];
        for (int i = 0; i< array.Length-1; i++)
        {
            if (min > array[i+1])
            min = array [i+1];
        }

    double diff = max - min;
    return diff;
}

