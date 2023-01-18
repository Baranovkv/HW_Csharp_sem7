// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры.
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

void Fill2dArrayRand(int[,] fillArray)
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
            Console.Write($"{printArray[i,j], 4}");            
        }    
        Console.WriteLine();
    }
}

void SortArray(int[,] sortArray)
{
    for (int i = 0; i < sortArray.GetLength(0); i++)
        for (int j = 0; j < sortArray.GetLength(1); j++)
            for (int k = 0; k < sortArray.GetLength(0); k++)
                for (int l = 0; l < sortArray.GetLength(1); l++)
                    if (sortArray[k,l] > sortArray[i,j])
                        (sortArray[i,j], sortArray[k,l]) = (sortArray[k,l], sortArray[i,j]);
}


Console.WriteLine("Enter the number rows in the array");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, rows];
Fill2dArrayRand(array);
Print2dArray(array);
SortArray(array);
Console.WriteLine("Sorted array:");
Print2dArray(array);