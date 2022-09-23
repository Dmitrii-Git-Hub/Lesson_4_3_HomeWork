// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double Distance(int x1,int x2,int y1,int y2,int z1,int z2)
{
return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
}

int xa, xb, ya, yb, za, zb;

Console.WriteLine("Введите координату X первой точки");
xa =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки");
za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки");
zb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Расстояние между ними в 3D пространстве: " + Distance(xa, xb ,ya, yb, za, zb));