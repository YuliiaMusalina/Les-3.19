// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int a = ReadInt("Написать первое число A: ");
int b = ReadInt("Написать второе число B: ");
int с = ReadInt("Написать третье число C: ");
int d = ReadInt("Написать четвертое число D:");
int e = ReadInt("Написать пятое число E: ");

if(a == e && b == d) 
{
    Console.WriteLine("Является паллиндромом");
}
else
{
    Console.WriteLine("Число не является паллиндромом");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
