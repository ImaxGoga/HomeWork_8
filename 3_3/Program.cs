// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

double[,] Result(double[,] matr1, double[,] matr2)
{
    double[,] matr3 = new double[matr1.GetLength(0), matr1.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for(int k = 0; k < matr2.GetLength(0); k++)
            {
                matr3[i, j] += matr1[i, k] * matr2[k, j];
            }            
        }
    }
    return matr3;
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
    double[,] mass1 = new double[2,2];
    double[,] mass2 = new double[2,2];
    // Тестовые данные:
    // double[,] mass1 = new double[2,2] {{2,4},{3,2}};
    // double[,] mass2 = new double[2,2] {{3,4},{3,3}};
    double[,] mass3 = new double[2,2];
    FillArray(mass1);
    FillArray(mass2);
    Console.WriteLine("Матрица1: ");
    PrintArray(mass1);
    Console.WriteLine();
    Console.WriteLine("Матрица2: ");
    PrintArray(mass2);
    mass3 = Result(mass1, mass2);
    Console.WriteLine();
    Console.WriteLine("Результирующая матрица: ");
    PrintArray(mass3);
    
}

foo();