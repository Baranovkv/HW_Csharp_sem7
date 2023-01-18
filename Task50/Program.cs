// Задача 50. Напишите программу, которая на вход принимает значение элемента 
// в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArrayDoubleRand(double [,] fillArray)
{
    for (int i = 0; i < fillArray.GetLength(0); i++)
        for (int j = 0; j < fillArray.GetLength(0); j++)
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

void NumberPosorion(double[,] posArray, double number)
{
    bool noNumber = true;
    for (int i = 0; i < posArray.GetLength(0); i++)
        for (int j = 0; j < posArray.GetLength(0); j++)
            if (posArray[i,j] == number)
            {
                Console.Write($"[{i},{j}] ");
                noNumber = false;
            }
    if (noNumber)
        Console.WriteLine("The number is absent");
}

Console.Write("Enter the rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [m,n];
FillArrayDoubleRand(array);
Print2dArray(array);
Console.Write("Enter the number to search: ");
double num = Convert.ToDouble(Console.ReadLine());
NumberPosorion(array, num);

