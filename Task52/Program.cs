// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArrayDoubleRand(int [,] fillArray)
{
    for (int i = 0; i < fillArray.GetLength(0); i++)
        for (int j = 0; j < fillArray.GetLength(1); j++)
            fillArray[i,j] = new Random().Next(-10,11);
}

void Print2dArray(int[,] printArray)
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

void AverageRow(int[,] averArray)
{
    double aver;
    for (int i = 0; i < averArray.GetLength(0); i++)
    {
        aver = 0;
        for (int j = 0; j < averArray.GetLength(1); j++)
            aver += averArray[i,j];
        Console.WriteLine
            ($"Average of numbers from {i + 1} row is {Math.Round(aver / Convert.ToDouble(averArray.GetUpperBound(0)), 2)}");
    }    
}

Console.WriteLine("Enter the rows number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the columns number");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m,n];
FillArrayDoubleRand(array);
Print2dArray(array);
AverageRow(array);