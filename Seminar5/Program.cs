﻿// Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i=0; i<size; i++)
    {
        array[i] =  new Random().Next(minValue, maxValue+1);
    }

    return array;
}

int GetSum(int[] arr)
{
    int sum = 0;
    for (int i=0; i<arr.Length; i++)
        if (arr[i]<0) sum += arr[i];

    return sum;
}

Console.Write("Input size of massive: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int sum = GetSum(CreateRandomArray(size, min, max));
Console.WriteLine("sum: "+sum);

*/

//Напишите программу замены элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i=0; i<size; i++)
    {
        array[i] =  new Random().Next(minValue, maxValue+1);
    }

    return array;
}

int[] PolarityReverse(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
        arr[i] *= -1;

    return arr;
}

void ShowArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }

    Console.WriteLine();
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = PolarityReverse(CreateRandomArray(size, min, max));

ShowArray(arr);
*/

//Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i=0; i<size; i++)
    {
        array[i] =  new Random().Next(minValue, maxValue+1);
    }

    return array;
}

bool InArray(int[] arr, int num)
{
    for (int i=0; i<arr.Length; i++)
        if (arr[i]==num) return true;

    return false;
}

void ShowArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }

    Console.WriteLine();
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRandomArray(size, min, max);

Console.Write("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowArray(arr);

if (InArray(arr, num)) Console.Write($"Array contains {num}");
else Console.Write($"Array does not contain {num}");

*/

//Задайте одномерный массив из m случайных чисел. 
//Найдите количество элементов массива, значения которых лежат 
//в отрезке [a,b].

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i=0; i<size; i++)
    {
        array[i] =  new Random().Next(minValue, maxValue+1);
    }

    return array;
}

int CountElements(int[] arr, int a, int b)
{
    int count = 0;

    for (int i=0; i<arr.Length; i++)
        if (arr[i]>=a && arr[i]<=b) count++;

    return count;
}

void ShowArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }

    Console.WriteLine();
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRandomArray(size, min, max);

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());

int count = CountElements(arr, a, b);

ShowArray(arr);

Console.Write("Count elements: " + count);
*/

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i=0; i<size; i++)
    {
        array[i] =  new Random().Next(minValue, maxValue+1);
    }

    return array;
}

int CountОfEvenNumbers(int[] arr)
{
    int count=0;

    for (int i=0; i<arr.Length; i++)
        if (arr[i] % 2 == 0) count++;

    return count;
}

void ShowArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");

    Console.WriteLine();
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRandomArray(size, 100, 999);

int count = CountОfEvenNumbers(arr);

ShowArray(arr);

Console.Write("Number of even numbers: " + count);
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i=0; i<size; i++)
    {
        array[i] =  new Random().Next(minValue, maxValue+1);
    }

    return array;
}

void ShowArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");

    Console.WriteLine();
}

int GetSum(int[]arr)
{
    int sum=0;

    for (int i=0; i<arr.Length; i=i+2)
        sum += arr[i];

    return sum;
}

Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input array min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input array max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRandomArray(size, min, max);

ShowArray(arr);

int sum = GetSum(arr);
Console.Write("Sum: "+sum);
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76