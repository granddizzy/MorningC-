// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

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

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
int NumberОfDigits(int num)
{
    int numberОfDigits=0;
    
    while (num>0)
    {
        num=num/10;
        numberОfDigits++;
    }

    return numberОfDigits;
}

//решение через математику
bool IsPalindrome(int num)
{
    int numberOfDigits=NumberОfDigits(num);
   
    // if (numberOfDigits==1) return true; 

    int max_i=numberOfDigits/2; 
    int i=1;

    while (i<=max_i)
    {
        //left digit
        int divider = Convert.ToInt32(Math.Pow(10, numberOfDigits-i));
        int leftDigit = num/divider - (num/(divider*10))*10; 

        //right digit
        divider = Convert.ToInt32(Math.Pow(10, i));
        int rightDigit = (num % divider)/(divider/10); 
         
        if (leftDigit != rightDigit) return false;
         
        i++;
    }

    return true;
}

//решение через строку
bool IsPalindromeString(string str)
{
    //string str = Convert.ToString(num);
    int numberOfSings = str.Length;

    int max_i=numberOfSings/2; 
    int i=1;
    while (i<=max_i)
    {
        if (str[i-1] != str[numberOfSings-i]) return false;
        i++;
    }

    return true;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (IsPalindromeString(Convert.ToString(num))) Console.WriteLine($"The number {num} is a palindrome");
else Console.WriteLine($"The number {num} is a NOT a palindrome");

if (IsPalindrome(num)) Console.WriteLine($"The number {num} is a palindrome");
else Console.WriteLine($"The number {num} is a NOT a palindrome");
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


/*
double Distance3D(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2));
}

int NumberInput(string text){
    Console.Write(text+": ");
    return Convert.ToInt32(Console.ReadLine());
}

int xa = NumberInput("Input Xa");
int ya = NumberInput("Input Ya");
int za = NumberInput("Input Za");

int xb = NumberInput("Input Xb");
int yb = NumberInput("Input Yb");
int zb = NumberInput("Input Zb");

double dist = Distance3D(xa, ya, za, xb, yb, zb);

Console.Write("Distance between points: "+Math.Round(dist,2));
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void DegreeTable(int n, int degree)
{
    int i = 1;
    while (i < n)
    {
        Console.WriteLine(i + " - " + Math.Pow(i, degree));
        i++;
    }
}


Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

DegreeTable(n, 3);