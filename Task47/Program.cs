// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArrayDoubleRand(double [,] fillArray)
{
    for (int i = 0; i < fillArray.GetLength(0); i++)
        for (int j = 0; j < fillArray.GetLength(0); j++)
            // fillArray[i,j] = Math.Round((new Random().NextDouble()* 100), 2);
            fillArray[i,j] = new Random().Next(-100,101) / 10.0;
}

void Print2dArray(double[,] printArray)
{
    for (int i = 0; i < printArray.GetLength(0); i++)
    {
        for (int j = 0; j < printArray.GetLength(1); j++)
        {
            Console.Write($"{printArray[i,j], 6}");            
        }    
        Console.WriteLine();
    }
}

Console.WriteLine("Enter the rows number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the columns number");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [m,n];
FillArrayDoubleRand(array);
Print2dArray(array);

