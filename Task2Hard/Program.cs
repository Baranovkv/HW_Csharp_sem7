// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , 
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. 
// Перемешать случайным образом элементы массива, причем чтобы каждый элемент 
// гарантированно и только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.

void FillArrayDoubleRand(int [,] fillArray)
{
    for (int i = 0; i < fillArray.GetLength(0); i++)
        for (int j = 0; j < fillArray.GetLength(1); j++)
            fillArray[i,j] = new Random().Next(-100,101);
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

void MixArray(int[,] mixArray)
{
    int[] tempIndAr = new int [mixArray.Length*2]; // создаем одномерный массив, в котором сохраним уникалные индексы для перемешивания
    tempIndAr[0] = new Random().Next(0,mixArray.GetLength(0)); // первый индекс отвечает за номер строки
    tempIndAr[1] = new Random().Next(0,mixArray.GetLength(1)); // второй - за столбец. И так далее
    int iTemp = new Random().Next(0,mixArray.GetLength(0));
    int jTemp = new Random().Next(0,mixArray.GetLength(1));

    for (int i = 2; i < tempIndAr.Length-1; i+=2) // цикл для создания уникального набора индексов элементов основного массива
    {
        for (int j = i; j > 0; j-=2)
            while (iTemp == tempIndAr[j-2] & jTemp == tempIndAr[j-1])
            {
                iTemp = new Random().Next(0,mixArray.GetLength(0));
                jTemp = new Random().Next(0,mixArray.GetLength(1));
                j = i;
            }
        tempIndAr[i] = iTemp;
        tempIndAr[i+1] = jTemp;
    }

    Console.WriteLine("Indexes of changed elements: "); // для наглядности и проверки вывел на экран пары индексов элементов для обмена
    Console.Write("| ");
    for (int i = 0; i < tempIndAr.Length; i++)
    {
        if (i % 2 == 0)
            Console.Write($"[{tempIndAr[i]},");
        else
            Console.Write($"{tempIndAr[i]}] ");
        if (i % 4 == 1)
            Console.Write("and ");
        if (i % 4 == 3)
            Console.Write("| ");
    }

    int count = 0; // счетчик для количества перемешиваний
    for (int i = 0; i < tempIndAr.Length-3; i+=4) // цикл для перемешивания пар элементов, количество перемешиваний общая длина массива/4
    {
        (mixArray[tempIndAr[i],tempIndAr[i+1]], mixArray[tempIndAr[i+2],tempIndAr[i+3]]) 
        = (mixArray[tempIndAr[i+2],tempIndAr[i+3]], mixArray[tempIndAr[i],tempIndAr[i+1]]);
        count++;
    }
    Console.WriteLine($"\nNumber of movements: {count}");

}


bool oddNum = true;
Console.WriteLine("Please create array with an even number elements");

try
{
    while (oddNum)
    {
        Console.Write("Enter the rows number: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the columns number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (m*n % 2 == 0)
        {
            oddNum = false;
            int[,] array = new int[m, n];
            FillArrayDoubleRand(array);
            Print2dArray(array);
            MixArray(array);
            Print2dArray(array);
        }
        else
            Console.WriteLine
                ("You try to create array with an odd number elements. \nPlease create array with an even number elements.");
    }
}
catch
{
    Console.WriteLine("Please etner the correct number of raws and columns in the array.");
}