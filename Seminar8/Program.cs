
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
    int iMinSum=0;

    for (int i=1; i<sumArr.Length; i++)
        if (sumArr[i]<sumArr[iMinSum])
            iMinSum=i;

    return iMinSum+1;
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

Console.WriteLine("Matrix 1:");
Show2dArray(matrix1);

Console.WriteLine("Matrix 2:");
Show2dArray(matrix2);

if (CheckPpossibilityMmultiplication(matrix1, matrix2))
{
    Console.WriteLine("The result of multiplying matrix 1 by matrix 2:");
    Show2dArray(MatrixMultiplication(matrix1, matrix2));
}
else
    Console.WriteLine("Sorry, but these matrices cannot be multiplied!");
*/


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
int[,,] CreateRandom3dArray()
{
    int x = 0;  
    while (x<=0)
    {
        Console.Write("Input array size x:");
        x = Convert.ToInt32(Console.ReadLine());
        if (x<=0) Console.Write("Invalid array size x! ");
    }

    int y = 0;  
    while (y<=0)
    {
        Console.Write("Input array size y:");
        y = Convert.ToInt32(Console.ReadLine());
        if (y<=0) Console.Write("Invalid array size y! ");
    }

    int z = 0;  
    while (z<=0)
    {
        Console.Write("Input array size z:");
        z = Convert.ToInt32(Console.ReadLine());
        if (z<=0) Console.Write("Invalid array size z! ");
    }

    int amountNumbers = 0, minValue = 1, maxValue = 0, countElements=x*y*z;
    while (amountNumbers<countElements)
    {
        while (maxValue<minValue)
        {
            Console.Write("Input a min value:");
            minValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a max value:");
            maxValue = Convert.ToInt32(Console.ReadLine());
            if (maxValue<minValue) Console.WriteLine("The maximum value is less than the minimum value!!! ");
        }
        
        amountNumbers=maxValue-minValue+1;
        
        if (amountNumbers<countElements)
        {
            Console.WriteLine("The number of possible unique values between min and max is less than necessary!!! ");
            maxValue=0; minValue=1;
        }
    }

    int[,,] array = new int[x, y, z];

    for (int i=0; i<x; i++)
        for (int j=0; j<y; j++)
            for (int k=0; k<z; k++)
            {
                int value = minValue-1; 
                while (value==minValue-1 || IsContainedIn3dArray(array, value))
                    value =  new Random().Next(minValue, maxValue+1);
    
                array[i,j,k] = value; 
            }

    return array;
}

bool IsContainedIn3dArray(int[,,] arr, int value)
{
    for (int i=0; i<arr.GetLength(0); i++)
        for (int j=0; j<arr.GetLength(1); j++)
            for (int k=0; k<arr.GetLength(2); k++)
                if (arr[i,j,k]==value)
                    return true;
    return false;
}

void Show3dArray(int[,,] arr)
{
    for (int k=0; k<arr.GetLength(2); k++)  
        for(int i = 0; i < arr.GetLength(0); i++)       
        {
            for (int j=0; j<arr.GetLength(1); j++)
                Console.Write(arr[i,j,k] + $"({i},{j},{k})" + " ");

            Console.WriteLine();
        }

    Console.WriteLine();
}

int[,,] arr = CreateRandom3dArray();
Show3dArray(arr);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*
//первое решение
int[,] CreateSpiralArray()
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

    int[,] array = new int[rows, cols];

    int i=0, j=0, count=0, value=1, countElements=rows*cols;

    while (value<=countElements)
    {
        while (j<cols-count && value<=countElements)
        {
            array[i,j] =  value;
            value++;
            j++;
        }

        j--; i++;
        while (i<rows-count  && value<=countElements)
        {
            array[i,j] =  value;
            value++;
            i++;   
        }

        i--; j--;
        while (j>=count && value<=countElements)
        {
            array[i,j] =  value;
            value++;
            j--;
        }

        j++; i--;
        while (i>count  && value<=countElements)
        {
            array[i,j] =  value;
            value++; 
            i--;
        }

        i++; j++; count++;
    }

    return array;
}

//второе решение
int[,] CreateSpiralArray2()
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

    int[,] array = new int[rows, cols];
    
    int startNum=1;
    
    int i=0, j=0, directionI=0, directionJ=1, 
    stepHorizontal=cols-1, stepVertical=rows-1, turningNumber=startNum+stepHorizontal;  

    for (int k=startNum; k<=rows*cols+startNum-1; k++)
    {
        array[i,j]=k;

        //проверка края и изменение направления
        if (k==turningNumber)
        {
            if (directionI==0 && directionJ==1) //делаем направление вниз
            {
                directionI=1; directionJ=0;
                turningNumber=turningNumber+stepVertical;
            } 
            else if (directionI==1 && directionJ==0) //делаем направление влево
            {
                directionI=0; directionJ=-1;
                turningNumber=turningNumber+stepHorizontal;
            } 
            else if (directionI==0 && directionJ==-1) //делаем направление вверх
            {
                directionI=-1; directionJ=0;
                if (stepVertical>1) stepVertical=stepVertical-2;
                turningNumber=turningNumber+stepVertical+1;
            } 
            else if (directionI==-1 && directionJ==0) //делаем навравление вправо  
            {
                directionI=0; directionJ=1;
                if (stepHorizontal>1) stepHorizontal=stepHorizontal-2; 
                turningNumber=turningNumber+stepHorizontal+1;
            }
        }

        i=i+directionI;
        j=j+directionJ;
    }

    return array;
}

// int GetMaxElement(int[,] arr)
// {
//     int res = arr[0,0];

//     for(int i = 0; i < arr.GetLength(0); i++)
//         for (int j=0; j<arr.GetLength(1); j++)
//             if (arr[i,j]>res) res = arr[i,j];

//     return res;
// }

int CountOfDigit(int num)
{
    if (num==0) return 1;

    int count=0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    
    return count;
}

void ShowSpiralArray(int[,] arr)
{
    int maxElement = arr.GetLength(0)*arr.GetLength(1);

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            int CountOfZero = CountOfDigit(maxElement) - CountOfDigit(arr[i,j]);

            string zeroString = string.Empty;

            for(int k=0; k<CountOfZero; k++)
                zeroString = zeroString + "0";

            Console.Write(zeroString + arr[i,j] + " ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] arr = CreateSpiralArray();
ShowSpiralArray(arr);

arr = CreateSpiralArray2();
ShowSpiralArray(arr);
*/