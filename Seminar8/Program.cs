
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

void ShowArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");

    Console.WriteLine();
    Console.WriteLine();
}

// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую 
// и последнюю строку массива.

/*
void ChangeRows(int[,] arr, int row1, int row2)
{
    if (row1>=0 && row1<arr.GetLength(0)
    && row2>=0 && row2<arr.GetLength(0)
    && row1!=row2)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            int tmp = arr[row1,j];
            arr[row1,j]=arr[row2,j];
            arr[row2,j]=tmp; 
        }
    }
}

int[,] arr=CreateRandom2dArray();
Show2dArray(arr);

Console.Write("Input 1 row: ");
int row1=Convert.ToInt32(Console.ReadLine())-1;
Console.Write("Input 2 row: ");
int row2=Convert.ToInt32(Console.ReadLine())-1;

ChangeRows(arr, row1, row2);
Show2dArray(arr);
*/

// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.

/*
void ConvertArray(int[,] arr)
{
    if (arr.GetLength(0)==arr.GetLength(1))
    {
        for (int i=0; i<arr.GetLength(0); i++)
        {
            for (int j=i; j<arr.GetLength(1); j++)
            {
                int temp = arr[i,j];
                arr[i,j]=arr[j,i];
                arr[j,i]=temp;
            }
        }
    }
}


int[,] arr = CreateRandom2dArray();
Show2dArray(arr);
ConvertArray(arr);
Show2dArray(arr);
*/

//Из двумерного массива целых чисел 
//удалить строку и столбец, на пересечении которых расположен наименьший элемент.

/*
int[] FindIndexes(int[,] arr)
{
    int[] indexesArr = new int[2];

     for (int i=0; i<arr.GetLength(0); i++)
        {
            for (int j=0; j<arr.GetLength(1); j++)
            {
                if (arr[i,j]<arr[indexesArr[0],indexesArr[1]])
                {
                    indexesArr[0]=i;
                    indexesArr[1]=j;
                }
            }
        }

    return indexesArr;
}

int[,] ChangeArray(int[,] arr, int row, int col)
{
    int[,] newArray = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];

    for (int i=0, newI=0; i<arr.GetLength(0); i++)
    {
        if (i==row) continue;
        else if (i>row) newI=i-1;
        else newI=i;

        for (int j=0, newJ=0; j<arr.GetLength(1); j++)
        {  
            if (j==col) continue;          
            else if (j>col) newJ=j-1;
            else newJ=j;

            newArray[newI,newJ]=arr[i,j];               
        }
    }

    return newArray;
}

int[,] arr = CreateRandom2dArray();


Show2dArray(arr);

int[] minIndexex = FindIndexes(arr);

// ShowArray(minIndexex);

arr = ChangeArray(arr, minIndexex[0], minIndexex[1]);

Show2dArray(arr);
*/

///////////////////////////////////////////////////////////////
//HOME WORK
///////////////////////////////////////////////////////////////

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
void SortDesc(int[,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
        for (int j=0; j<arr.GetLength(1)-1; j++)
            for (int k=0; k<arr.GetLength(1)-1-j; k++)
            {
                if (arr[i,k+1]>arr[i,k])
                {
                    int tmp = arr[i,k];
                    arr[i,k] = arr[i,k+1];
                    arr[i,k+1]=tmp;
                }
            }
}

int[,] arr = CreateRandom2dArray();
Show2dArray(arr);
SortDesc(arr);
Show2dArray(arr);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int[] GetSumElementsRows(int[,] arr)
{
    int[] sumArr = new int[arr.GetLength(0)];

    for (int i=0; i<arr.GetLength(0); i++)
        for (int j=0; j<arr.GetLength(1); j++)
            sumArr[i] += arr[i,j];  

    return sumArr;
}

int GetNumRowMinSum(int[,] arr)
{
    int[] sumArr = GetSumElementsRows(arr);
    int numRow=0;

    for (int i=1; i<sumArr.Length; i++)
        if (sumArr[i]<sumArr[numRow])
            numRow=i;

    return numRow+1;
}

int[,] arr = CreateRandom2dArray();
Show2dArray(arr);
Console.WriteLine("Row number with minimum sum of elements: " + GetNumRowMinSum(arr));

*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    // Результатом умножения матриц Am×n и Bn×k будет матрица Cm×k такая, что элемент матрицы C, стоящий в i-той строке и j-том столбце (cij), 
    // равен сумме произведений элементов i-той строки матрицы A на соответствующие элементы j-того столбца матрицы B:
    // cij = ai1 · b1j + ai2 · b2j + ... + ain · bnj

    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i=0; i<newMatrix.GetLength(0); i++)
        for (int j=0; j<newMatrix.GetLength(1); j++)
            for (int k=0; k<matrix1.GetLength(1); k++)
                newMatrix[i,j] += matrix1[i, k] * matrix2[k, j];

    return newMatrix;
}

bool CheckPpossibilityMmultiplication(int[,] matrix1, int[,] matrix2)
{
    // Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором

    if (matrix1.GetLength(1)==matrix2.GetLength(0))
        return true;
    
    return false;
}

Console.WriteLine("First matrix parameters:");
int[,] matrix1 = CreateRandom2dArray();
Console.WriteLine("Second matrix parameters:");
int[,] matrix2 = CreateRandom2dArray();

Show2dArray(matrix1);
Show2dArray(matrix2);

if (CheckPpossibilityMmultiplication(matrix1, matrix2))
    Show2dArray(MatrixMultiplication(matrix1, matrix2));
else
    Console.WriteLine("Sorry, but these matrices cannot be multiplied!");

*/