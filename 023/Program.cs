// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void TabCub(int N)
{
int count = 1;
while (count < N +1)
{
    Console.Write(Math.Pow(count, 3) + " ");
    count = count + 1;
}
}

Console.WriteLine("Введите число, чтобы получить таблицу кубов чисел от 1 до этого числа:");
TabCub(Convert.ToInt32(Console.ReadLine()));