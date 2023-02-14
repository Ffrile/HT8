// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int m = new Random().Next(2, 3);
int n = new Random().Next(2, 3);

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 5);
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

int[,] MultipleArrays(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i, j] += array1[i, j] * array2[k, j];
            }
        }
    }
    return result;
}

int[,] array1 = Generate2DArray(m, n);
int[,] array2 = Generate2DArray(m, n);
Print2DArray(array1);
System.Console.WriteLine();
Print2DArray(array2);
System.Console.WriteLine();
Print2DArray(MultipleArrays(array1, array2));

// не успел с этой задачей и последней, был перегружен на работе, сдам со следующим домашим заданием