// int num = -12;
// double bigNum = 12.13;
// bool  isEven = true;
// string word = "flower";
// char symbol = 's';


// int num1 = -12;
// int num2 = 6;
// Console.WriteLine("My number is "+num1+" and "+num2+" and it is good!");
// Console.WriteLine($"My number is {num1} and {num2} and it is good!");

// Console.Write("Input integer number:");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("You number is "+num);

//Home work1
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Console.Write("Input a first number:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a second number:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quard2 = int2*int2;

// if (num1==quard2)
// {
//     Console.Write("Yes");
// }
// else
// {
//     Console.Write("No");
// }

//Home work2
//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("Input a positive number:");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = -num;

// while (current<=num)
// {
//     Console.Write(current+" ");
//     current++;
// } 

// 31542 / 10 = 3154
// 31542 / 100 = 315
// 31542 / 1000 = 31
// 31542 / 10000 = 3

// 31542 % 10 = 2
// 31542 % 100 = 42
// 31542 % 1000 = 542
// 31542 % 10000 = 1542

// 453216 -> 32

////////////////////////////////
// HOME WORK 
////////////////////////////////

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input a first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
    Console.Write($"The first number {num1} is greater than the second number {num2}");    
else if (num1<num2)
    Console.Write($"The second number {num2} is greater than the first number {num1}"); 
else
    Console.Write("The numbers are equal");
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a third number:");
int num3 = Convert.ToInt32(Console.ReadLine());

int maxNum=num1;

if (num2>maxNum)
    maxNum=num2; 

if (num3>maxNum)
    maxNum=num3; 
    
Console.Write("Max number is: " + maxNum);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a number:");
int num = Convert.ToInt32(Console.ReadLine());

int remainder=num % 2;

if (remainder==0)
    Console.Write("Yes");
else
    Console.Write("No");
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input a positive number:");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current <= num)
{
    Console.Write(current+" ");
    current=current+2;
}
*/