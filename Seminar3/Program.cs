﻿// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*
viod ShowRange(int quard)
{
    if(quard==1) Console.WriteLine("x > 0 and y > 0");
    else if(quard==2) Console.WriteLine("x < 0 and y > 0");
    else if(quard==3) Console.WriteLine("x < 0 and y < 0");
    else if(quard==4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Incorrect input"); 
}

Console.Write("Input a number of quadrant: ");
int quadrant = Convert.ToInt32(Console.ReadLine());

ShowRange(quadrant);
*/

// Программа на длину отрезка по координатам

/*

double Distance(double xa, double xb, double ya, double yb)
{
    double firstLenght=xb-ya;
    double secondLenght=yb-ya;
    double quard = Math.Sqrt(Math.Pow(firstLenght,2)+Math.Pow(secondLenght,2));

    return quard;
}

Console.Write("Input a Xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Yb: ");
int yb = Convert.ToInt32(Console.ReadLine());

double dist = Distance(xa, ya, xb, yb);

Console.Write("Distance: "+Math.Round(dist,2));

*/


// Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
int NumberQuadrant(int x, int y)
{
    if (x>0 && y>0) return 1;
    if (x<0 && y>0) return 2;
    if (x<0 && y<0) return 3;  
    if (x>0 && y<0) return 4;
    
    return -1;
}

Console.Write("Input a X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int res = NumberQuadrant(x, y);

if (res==-1) Console.Write("Invalid input");
else Console.Write("Quadrant: "+res);
*/

//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.

/*
void SquareTable(int n)
{
    int i=1;
    while (i<=n)
    {
        Console.WriteLine(i*i);
        i++;
    }
}

Console.Write("Input a N: ");
int n = Convert.ToInt32(Console.ReadLine());

SquareTable(n);
*/