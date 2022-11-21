/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве. */
Console.WriteLine("Введите точку координат А1");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку координат А2");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку координат А3");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку координат B1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку координат B2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку координат B3");
int b3 = Convert.ToInt32(Console.ReadLine());
double num = Math.Sqrt(Math.Pow(a1-b1, 2)+Math.Pow(a2-b2, 2)+Math.Pow(a3-b3, 2));
Console.WriteLine(num);
