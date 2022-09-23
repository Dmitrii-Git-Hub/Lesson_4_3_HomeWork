// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
bool Palindrom(int number)
{
    return (number / 10000 == number % 10) && (number / 1000 % 10 == number % 100 / 10);
}

Console.WriteLine("Введите пятизначное число:");

if (Palindrom(Convert.ToInt32(Console.ReadLine())))
{
    Console.WriteLine("Это палиндром.");
}
else
{
    Console.WriteLine("Это не палиндром.");
}

