// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,0,1)
// 34(0,1,0) 41(0,1,1)
// 27(1,0,0) 90(1,0,1)
// 26(1,1,0) 55(1,1,1)

void FillArray(int[,,] mass)
{
    int flag = 0;
    int N;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                do
                {
                N = new Random().Next(10,99);
                for (int i1 = 0; i1 < i; i1++)
                {
                    for (int j1 = 0; j1 < j; j1++)
                    {
                        for (int k1 = 0; k1 < k; k1++)
                        {
                            if(N == mass[i1,j1,k1])
                            flag = 1;
                        }
                    }
                }                
                } while(flag == 1 );
                flag = 0;
                mass[i,j,k] = N;
                Console.Write($"{mass[i,j,k]}({i},{j},{k}) ");
            }
        }
    }
}

void foo()
{
    int[,,] mass = new int[2,2,2];
    FillArray(mass);
}

foo();