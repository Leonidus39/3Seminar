/* Задача 23
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N. */
Console.WriteLine("Введите число");
double num =  Convert.ToInt32(Console.ReadLine());
for (double i = 1; i <= num; i++) 
Console.Write($"{Math.Pow(i, 3)}, ");

