//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i=0; i<size; i++)
        array[i] =  new Random().Next(minValue, maxValue+1);

    return array;
}

void ShowArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");

    Console.WriteLine();
}

void ReverseArray(int[] arr)
{
    for(int i=0, j = arr.Length - 1; i<j; i++, j--)
        {
            int temp = arr[i];
        arr[i] = arr[j];
         arr[j] = temp;
    }
}

int[] arr = CreateRandomArray(10,1,9);

ShowArray(arr);
ReverseArray(arr);
ShowArray(arr);
*/

//Напишите программу, которая принимает на вход три числа 
//и проверяет, может ли существовать треугольник с сторонами такой длины.

/*
bool CheckExist(int a, int b, int c){
    return a<b+c && b<a+c && c<a+b;
}

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input c: ");
int c = Convert.ToInt32(Console.ReadLine());

bool res = CheckExist(a,b,c);

if (res) Console.WriteLine("Треугольник может существовать");
else Console.WriteLine("The triangle cannot exist");
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: a и b.

/*
void ShowFibonacci(int quantity, int a, int b){
    
    int temp;
    for (int i=1; i<=quantity; i++)
    {
        Console.Write(a+b+" ");        
        temp=a;
        a=b;
        b=temp+b;
    }

    Console.WriteLine();
}

Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowFibonacci(n, 1, 1);
*/

//Напишите программу, которая будет создавать копию заданного массива с 
//помощью поэлементного копирования.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i=0; i<size; i++)
        array[i] =  new Random().Next(minValue, maxValue+1);

    return array;
}

void ShowArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");

    Console.WriteLine();
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];

    for (int i=0; i<array.Length; i++)
    {
        newArray[i]=array[i];
    }

    return newArray;
}

int[] arr = CreateRandomArray(10, 1, 9);
ShowArray(arr);
ShowArray(CopyArray(arr));
*/

//Напишите программу, 
//которая будет преобразовывать десятичное число в двоичное.

/*
string ConvertToBin(int number)
{
    string res=String.Empty;
    while (number>0)
    {
        res = number % 2 + res;
        number = number / 2;
    }

    return res;
}

Console.Write("Input dec number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ConvertToBin(number));
*/

//////////////////////////////////////////////
//HOME WORK
//////////////////////////////////////////////


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
int CountOfPositiveNumbers(int m)
{
    int count=0;
    for (int i=1; i<=m; i++)
    {
        Console.Write($"Input number {i}: ");
        if (Convert.ToInt32(Console.ReadLine()) > 0) count++;
    }

    return count;
}

int m=0;
while (m<=0) 
{
    Console.Write("Input positive integer M: ");
    m = Convert.ToInt32(Console.ReadLine());

    if (m<=0) Console.Write("Incorrect M !!! ");
}

Console.Write("Count of positive numbers: "+CountOfPositiveNumbers(m));
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1*x+b1=k2*x+b2   
// x=(b2-b1)/(k1-k2)
// y=k1*x+b1

/*
void FindIntersection(double b1, double b2, double k1, double k2)
{
    if (k1==k2) Console.WriteLine("There are no intersection points. The lines are parallel.");
    else
    {
        double x=(b2-b1)/(k1-k2);
        double y=k1*x+b1;

        Console.WriteLine($"Intersection coordinates x:{x} y:{y}");
    }
}

Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

FindIntersection(b1, b2, k1, k2);
*/