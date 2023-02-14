// Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.

/*
int Cutnumber(int num)
{
    int hundreds=num/100;
    int units=num % 10;
    int result=hundreds*10+units;
    
    return result;
}

int randNumber = new Random().Next(100,1000);

int newNumber = Cutnumber(randNumber);

Console.Write($"New version of {randNumber} in {newNumber}");
*/

// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно a и b.

/*
bool IsMultiplyed(int num, int div1, int div2)
{
    // if (num % div1 == 0 && num % div2==0)
    //     return true;
    // else
    //     return false;

    return num % div1 == 0 && num % div2==0;
}

Console.Write("Input a number:");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a first divider:");
int div1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second divider:");
int div2 = Convert.ToInt32(Console.ReadLine());

bool res = IsMultiplyed(num, div1, div2);

if (res)
    Console.Write($"Your number {} is");
else
    Console.Write($"");
*/

// Напишите программу, которая выводит случайное число из отрезка 
//[10, 99] и показывает наибольшую цифру числа.

/*
int GetMaxNumber(int num){
    int dozens=num/10;
    int units=num % 10;
    
    if (dozens>=units)
        return dozens;
    else
        return units;
} 

int randNumber = new Random().Next(10,100);

Console.WriteLine(randNumber);
Console.Write(GetMaxNumber(randNumber));
*/


//Напишите программу, которая принимает на вход два числа 
//и проверяет, является ли одно число квадратом другого.

/*
bool IsQuard(int num1, int num2){
    if (num1*num1==num2)
        return true;

    if (num2*num2==num1)
        return true;

    return false;
}

Console.Write("Input a first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = IsQuard(num1, num2);
Console.Write(result);
*/

////////////////////////
// HOME WORK
////////////////////////

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int GetSecondDigit(int num)
{
    int dozens = num / 10;
    int res = dozens % 10;
    
    return res;
}

bool IsCorrectNumber(int num)
{
    return num >= 100 && num <= 999;
} 

Console.Write("Input a three-digit number:");
int num = Convert.ToInt32(Console.ReadLine());

if (IsCorrectNumber(num))
{
    int secondDigit = GetSecondDigit(num);
    Console.Write($"Second digit in {num} is {secondDigit}");
}
else Console.Write($"You entered an invalid (not thee digits) number {num}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int GetThirdDigit(int num)
{
    if (num<100) return -1;

    while (num > 999) num = num / 10;

    int res = num % 10;

    return res;
}

Console.Write("Input a number:");
int num = Convert.ToInt32(Console.ReadLine());

int thirdDigit = GetThirdDigit(num);

if (thirdDigit == -1)
    Console.Write($"The third digit in {num} is missing");
else
    Console.Write($"Third number in {num} is {thirdDigit}");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool IsWeekend(int dayNum)
{
    return dayNum==6 || dayNum==7;
}

bool IsDayOfWeek(int num)
{
    return num>=1 && num<=7;
}

Console.Write("Input the number of the day of the week:");
int num = Convert.ToInt32(Console.ReadLine());

if (IsDayOfWeek(num))
{
    if (IsWeekend(num)) Console.Write($"Day of the week number {num} is a weekend");
    else Console.Write($"Day of the week number {num} is a working day");
}
else Console.Write($"Entered day number {num} is not a day of the week");
*/