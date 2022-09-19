// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintArray(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10);
        }
    }
}

void SortArray(double[,] matr) {
    for(int i = 0; i < matr.GetLength(0); i++) 
    {
        bool needSort = true;
        while(needSort) 
        {
            needSort = false;
            for(int j = 0; j < matr.GetLength(1) - 1; j++) 
            {
                double v1 = matr[i, j];
                double v2 = matr[i, j + 1];
                if(v1 < v2) 
                {
                    matr[i, j] = v2;
                    matr[i, j + 1] = v1;
                    needSort = true;
                }
            }
        }
    }
}

void foo()
{
    double[,] mass = new double[3,4];
    FillArray(mass);
    Console.WriteLine("Массив ДО сортировки: ");
    PrintArray(mass);
    Console.WriteLine();
    SortArray(mass);
    Console.WriteLine("Массив ПОСЛЕ сортировки: ");
    PrintArray(mass);
}

foo();