// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.


// 1 РЕШЕНИЕ САМОЕ И САМОЕ ПРОСТОЕ

// int[,,] Generate3DArray(int m, int n, int h)
// {
//     int[,,] result = new int[m, n, h];
//     int stupid = 10; 
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             for (int k = 0; k < result.GetLength(2); k++)
//             {
//                 result[i, j, k] = stupid++; 
//             }
//         }
//     }
//     return result;
// }

// void Print2DArray(int[,,] arr)
// {

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 Console.WriteLine($"{arr[i, j, k]} индексы {i},{j},{k}");
//             }
//         }
//         System.Console.WriteLine();

//     }
//     System.Console.WriteLine();
// }
// Print2DArray(Generate3DArray(4, 4, 4));


// 2 РЕШЕНИЕ (ДЛЯ ПРОСТОТЫ ПРОСМОТРА УСТАНОВИЛ РАЗМЕР МАССИВА 2.2.2 И РАНДО ОТ 1 ДО 8)

int[,,] Generate3DArray(int m, int n, int h)
{
    int[,,] result = new int[m, n, h];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = new Random().Next(1, 9);
            }
        }
    }
    return result;
}

void Print2DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"{arr[i, j, k]} индексы {i},{j},{k}");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();

    }
    System.Console.WriteLine();

}


int[,,] Compare(int[,,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int q = 0;
                while (q < array.GetLength(0))
                {
                    int w = 0;
                    while (w < array.GetLength(1))
                    {
                        int e = 0;
                        while (e < array.GetLength(2))
                        {
                            temp = array[i, j, k];
                            array[i, j, k] = 0;
                            if (temp == array[q, w, e])
                            {
                                array[i, j, k] = new Random().Next(1, 9);
                                i = 0;
                                j = 0;
                                k = 0;
                            }
                            else array[i, j, k] = temp;
                            e++;
                        }
                        w++;
                    }
                    q++;
                }

            }
        }
    }
    return array;
}

int[,,] array = Generate3DArray(2, 2, 2);
Print2DArray(array);
System.Console.WriteLine();
Print2DArray(Compare(array));

