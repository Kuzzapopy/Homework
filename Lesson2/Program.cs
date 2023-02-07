//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Metod (int number)
{
    int number = ( number / 10) % 10 ;
    return number;
}


Console.Write ( " Введите 3-ех значное число");
int num = Convert.ToInt32( Console.ReadLine());
int result ;
if ( number > 99 && number < 1000)
{
    result = Metod(num);
    Console.WriteLine( $" Вторая цифра { result }" );
}
else
    Console.WriteLine (" Вы ввели не 3-ех значное число");
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*int Metod (int number)
{
    number = number % 10 ;
    return number;
}

Console.Write ( " Введите число");
int number = Convert.ToInt32( Console.ReadLine());
int result ;
if ( number > 99 && number < 1000)
{
    result = Metod(number);
    Console.WriteLine( $" Третья цифра { result }" );
}
else
    Console.WriteLine (" Третей цифры нет");
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/* int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Под цифрой " + a + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    return " день.";
}*/