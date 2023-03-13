
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