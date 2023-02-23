//сумма чисел
/*
int GetSum(int a)
{
    int sum = 0;
    for (int current = 1; current <= a; current++)
    {
        sum += current;
    }

    return sum;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = GetSum(number);
Console.WriteLine($"Sum of numbers from 1 to {number} us {res}");
*/

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int NumberCount(int number)
{
    int count=0;

    while (number>0)
    {
        count++;
        number=number/10;
    }
   
   return count;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = NumberCount(number);
Console.WriteLine($"Count numers of {number} is {res}");

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int GetSum(int a)
{
    int sum = 1;
    for (int current = 1; current <= a; current++)
    {
        sum = sum * current;
    }

    return sum;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = GetSum(number);
Console.WriteLine($"Sum of numbers from 1 to {number} us {res}");
*/

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i =0; i<size;i++)
    {
        array[i] =  new Random().Next(minValue, maxValue+1)
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(Array[i] = " ");
    }

    Console.WriteLine();
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
*/

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int NaturalDegree(int a, int b)
{
    if (b==0) return 1;

    int res = a;

    for (int i=2; i<=b; i++)
    {
        res=res*a;
    }

    return res;
}

Console.Write("Input a integer value: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a degree: ");
int b = Convert.ToInt32(Console.ReadLine());

int res = NaturalDegree(a, b);

Console.Write("a to degree b: " + res);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int SumDigit(int num)
{
    int res=0;
    int temp=0;

    while (num>0)
    {
        temp=num/10;
        res=res+num-temp*10;
        num=temp;
    }

    return res;
}

Console.Write("Input a integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = SumDigit(num);

Console.Write("Sum digits of num: " + res);
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
/*
int[] ArrayInput(int size)
{
    int[] arr = new int[size];

    for (int i=0; i<size; i++)
    {
        Console.Write($"Input a {i+1} of massive number: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());

    }

    return arr;
}

void ShowArray(int[] array)
{
    Console.Write("[");

    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]);
        if (i<array.Length-1) Console.Write(", ");
    }

    Console.WriteLine("]");
}

Console.Write("Input size of massive: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr=ArrayInput(size);
ShowArray(arr);
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i =0; i<size;i++)
    {
        array[i] =  new Random().Next(minValue, maxValue+1);
    }

    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[");

    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]);
        if (i<array.Length-1) Console.Write(", ");
    }

    Console.WriteLine("]");
}

Console.Write("Input size of massive: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr=CreateRandomArray(size, min, max);
ShowArray(arr);
*/