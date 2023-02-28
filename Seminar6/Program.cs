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