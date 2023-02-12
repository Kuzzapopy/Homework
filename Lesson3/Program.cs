//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/* int Palidrom( int numberLength)
{
    if ( )
}


Console.WriteLine ("Введите 5-ти значное число: ");
string number = Console.ReadLine();
int len = number.Length;

if ( len == 5)
{

}
*/
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
int x1 = ReadInt("Введите х для точки 1: ");
int y1 = ReadInt("Введите y для точки 1: ");
int z1 = ReadInt("Введите z для точки 1: ");
int x2 = ReadInt("Введите х для точки 2: ");
int y2 = ReadInt("Введите y для точки 2: ");
int z2 = ReadInt("Введите z для точки 2: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Расстояние = " + length);

// Метод
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите число: ");
Console.WriteLine ( "Кубы заданного числа:");

for (int i = 1; i <= number; i++)
{
    Console.Write($" {i * i * i}, ");
}