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