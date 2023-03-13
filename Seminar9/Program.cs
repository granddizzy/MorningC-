
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.

/*
void ShowNums(int num)
{
    if (num > 1) ShowNums(num-1);
    Console.Write(num+" ");
}

int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);
*/

//Напишите программу, которая будет принимать на вход число 
//и возвращать сумму его цифр.

/*
int SumDigits(int num)
{
    if(num / 10 != 0) return SumDigits(num / 10) + Math.Abs(num % 10);

    return Math.Abs(num);
}

Console.WriteLine(SumDigits(10));
*/

//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

/*
void ShowNums(int m, int n)
{ 
    if (m<n-1)
    {
        Console.Write(m+1+" ");
        ShowNums(m+1, n);
    }
    else if (m>n+1)
    {
        ShowNums(m,n+1);
        Console.Write(n+1+" ");
    }
}

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(m, n);
*/

//Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B.

/*
double Pow(double a, double b)
{
    if (b>0)
        return a*Pow(a , b-1);
    else if (b<0)
        return (1/a) * Pow(a , b+1);
    else
    {
        return 1;
    }
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Pow(a,b));

*/

/////////////////////////////////////////////////////////////////////////////
//HOME WORK
/////////////////////////////////////////////////////////////////////////////

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowNaturalNumbers(int n)
{
    Console.Write(n-1+" ");
    if (n-1>1) ShowNaturalNumbers(n-1);
}

Console.Write("Input N:");
int n = Convert.ToInt32(Console.ReadLine());
ShowNaturalNumbers(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int GetSumNaturalElements(int n, int m)
{
    if (n>m+1)
        return m + 1 + GetSumNaturalElements(n, m+1);
     else if (n+1<m)
         return n + 1 + GetSumNaturalElements(n+1, m);

    return 0;
}

Console.Write("Input N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input M:");
int m = Convert.ToInt32(Console.ReadLine());
int sumNaturalElements = GetSumNaturalElements(n, m);

Console.WriteLine($"sum of natural elements between {n} and {m} is {sumNaturalElements}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*
int AcermanFunction(int m, int n)
{   
    if (m==0) return n+1;
    else if (m>0 && n==0) return AcermanFunction(m-1, 1);
    else return AcermanFunction(m-1, AcermanFunction(m, n-1));
}

int m = -1;  
while (m<0)
{
    Console.Write("Input M:");
    m = Convert.ToInt32(Console.ReadLine());
    if (m<0) Console.Write("Invalid value M. ");
}

int n = -1;  
while (n<0)
{
    Console.Write("Input N:");
    n = Convert.ToInt32(Console.ReadLine());
    if (n<0) Console.Write("Invalid value N. ");
}

int a = AcermanFunction(m, n);
Console.WriteLine($"Value Acerman function with numbers {m} and {n} is {a}");
*/