// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
int m = new Random().Next(1, 5);
int n = new Random().Next(1, 5);

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];

    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinSumElRows(int[,] array)
{
    int min = 0; int str = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i, j];
        }
        if (i > 0 && summ < min)
        {
            min = summ;
            str = i;
        }
        if (i == 0)
        {
            min = summ;
            str = i;
        }
    }
    Console.WriteLine($"№ строки с наименьшей суммой элементов ({min}): {str + 1} ");
}

int[,] array = Generate2DArray(m, n);
Print2DArray(array);
System.Console.WriteLine();
MinSumElRows(array);
