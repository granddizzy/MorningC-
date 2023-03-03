// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

int[,] CreateRandom2dArray()
{
    int rows = 0;  
    while (rows<=0)
    {
        Console.Write("Input the number of array rows:");
        rows = Convert.ToInt32(Console.ReadLine());
        if (rows<=0) Console.Write("Invalid number of rows! ");
    }

    int cols = 0;  
    while (cols<=0)
    {
        Console.Write("Input the number of array columns:");
        cols = Convert.ToInt32(Console.ReadLine());
        if (cols<=0) Console.Write("Invalid number of columns! ");
    }

    Console.Write("Input a min value:");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max value:");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, cols];

    for (int i=0; i<rows; i++)
        for (int j=0; j<cols; j++)
            array[i,j] =  new Random().Next(minValue, maxValue+1);

    return array;
}

void Show2dArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
            Console.Write(arr[i,j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

/*
int[,] arr = CreateRandom2dArray();
Show2dArray(arr);
*/

// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aij = i + j. 
// Выведите полученный массив на экран.

/*
int[,] CreateRandomArray()
{
    Console.Write("Input a number rows:");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number cols:");
    int cols = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, cols];

    for (int i=0; i<rows; i++)
        for (int j=0; j<cols; j++)
            array[i,j] =  i+j;

    return array;
}
*/

// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

void Replacement(int[,] arr)
{
    for (int i=0; i<arr.GetLength(0); i=i+2)
    {
        for (int j=0; j<arr.GetLength(1); j=j+2)
        {
            // if (i % 2 == 0 && j % 2 == 0)
                arr[i,j]=arr[i,j]*arr[i,j];
        }
    }
}

/*
int[,] arr = CreateRandom2dArray();
Show2dArray(arr);
Replacement(arr);
Show2dArray(arr);
*/


// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.


int GetSumDiagonal(int[,] arr)
{
    int res=0;

    for(int i=0; i<arr.GetLength(0) && i<arr.GetLength(1); i++)
        res=res + arr[i,i];

    return res;
}

/*
int[,] arr = CreateRandom2dArray();
int sum = GetSumDiagonal(arr);

Show2dArray(arr);
Console.WriteLine(sum);
*/

/////////////////////////////////////////////////////////////////
//HOME WORK
/////////////////////////////////////////////////////////////////

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Show2dDoubleArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
            Console.Write(arr[i,j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

double[,] CreateRandom2dDoubleArray()
{
    int rows = 0;  
    while (rows<=0)
    {
        Console.Write("Input the number of array rows:");
        rows = Convert.ToInt32(Console.ReadLine());
        if (rows<=0) Console.Write("Invalid number of rows! ");
    }

    int cols = 0;  
    while (cols<=0)
    {
        Console.Write("Input the number of array columns:");
        cols = Convert.ToInt32(Console.ReadLine());
        if (cols<=0) Console.Write("Invalid number of columns! ");
    }

    Console.Write("Input a min value:");
    double minValue = Convert.ToDouble(Console.ReadLine());

    Console.Write("Input a max value:");
    double maxValue = Convert.ToDouble(Console.ReadLine());

    double[,] array = new double[rows, cols];

    for (int i=0; i<rows; i++)
        for (int j=0; j<cols; j++)
            array[i,j] =  Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);

    return array;
}

/*
double[,] arr = CreateRandom2dDoubleArray();
Show2dDoubleArray(arr);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

/*
void SearchElement(int[,] arr, int row, int col)
{
    if (row>arr.GetLength(0)+1 
        || row<=0
        || col>arr.GetLength(1)+1
        || col<=0)
        Console.WriteLine($"There is no element with indexes [{row},{col}] in the array");
    else
        Console.WriteLine($"Element value with indexes [{row},{col}]: {arr[row-1,col-1]}");
}

int[,] arr = CreateRandom2dArray();

Console.Write("Enter the row number of the element you are looking for:");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the column number of the element you are looking for:");
int col = Convert.ToInt32(Console.ReadLine());

SearchElement(arr, row, col);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] ArithmeticMeansOfColumns(int[,] arr)
{
    double[] resArr = new double[arr.GetLength(1)];
    double sum=0;

    for (int i=0; i<arr.GetLength(1); i++)
    {
        sum=0;    
        for (int j=0; j<arr.GetLength(0); j++)
           sum += arr[j,i];
           
        resArr[i] = sum / arr.GetLength(0);
    }  
    
    return resArr;
}


int[,] arr = CreateRandom2dArray();

double[] arrArithmeticMeansOfColumns = ArithmeticMeansOfColumns(arr);

Show2dArray(arr);

Console.Write("Arithmetic mean of each column: ");
for (int i=0; i<arrArithmeticMeansOfColumns.Length; i++)
    Console.Write(Math.Round(arrArithmeticMeansOfColumns[i],2) + " ");
