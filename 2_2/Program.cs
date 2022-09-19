// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Result(double[,] matr)
{
    double Summ = 0, Min=0; 
    int flag = 1;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        Min = Min + matr[0,i];
    }

    for (int i = 1; i < matr.GetLength(0); i++)
    {
        Summ = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Summ = Summ + matr[i,j];
        }
        if(Summ < Min)
        {
            Min  = Summ;
            flag = i+1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма в {flag} строке.");
}

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

void foo()
{
    double[,] mass = new double[3,4];
    FillArray(mass);
    Console.WriteLine("Массив: ");
    PrintArray(mass);
    Console.WriteLine();
    Result(mass);
}

foo();