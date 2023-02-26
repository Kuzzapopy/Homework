//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*

void MathPow(double a, double b)
{
    double c ;
    c = Math.Pow(a, b);
    Console.WriteLine($" Степень чисел  { a } и  {b}  равна =  { c}");
}

double a;
double b;
Console.WriteLine("Пожалуйста, введите число, которое вы хотите возвести в степень:");
 a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Спасибо, теперь введите степень, в которую хотите возвести число "+a+":");
 b = Convert.ToDouble(Console.ReadLine());

if( a > 0 && b > 0)
{
    MathPow(a, b);
}
else
{
    Console.WriteLine( "Вы ввели число, которое нельзя использовать для возвидения в натуральную степень!!");
}
*/
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
void Sum( int a )
{
    int result = 0;
    while (a > 0)
    {
        result += a % 10 ;
        a = a / 10;
    }
    Console.WriteLine($"Сумма всех цифр равна { result } ");
}

Console.WriteLine(" Привет! Это программа покажет сумму всех цифр в числе. Введи число))");
int user_num = Convert.ToInt32(Console.ReadLine());

if( user_num > 0)
{
    Sum( user_num);
}
else
{
    Console.WriteLine( "Вы ввели число, с которым нельзя работать. Введите число от 1 и выше, не 0 и не минусовое число");
}
*/
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}