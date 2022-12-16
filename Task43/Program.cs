﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Метод перебора

Console.Write("Enter k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");

void Intersection(double k1, double b1, double k2, double b2)
{
    Console.Write($"The equation of the first line y1 = {k1}*x + {b1} ");
    Console.WriteLine(" ");
    Console.Write($"The equation of the first line y2 = {k2}*x + {b2} ");
    Console.WriteLine(" ");
    Console.WriteLine(" ");

    double x = -100;
    double y1;
    double y2;
    double delta;

    while (x < 100)
    {
        y1 = k1 * x + b1;
        y2 = k2 * x + b2;
        delta = Math.Abs(y1 - y2);
        if (k1 == k2 && b1 != b2)
        {
            Console.WriteLine("Straight lines don't intersect using brute force");
            break;
        }
        if (k1 == k2 && b1 == b2)
        {
            Console.WriteLine("Straight lines straight lines match");
            break;
        }
        if (delta < 0.0001)
        {
            Console.Write($"Intersection point is found using brute force x = {Math.Round(x, 2)}, y = {Math.Round(y1, 2)}");
            Console.WriteLine(" ");
            break;
        }
        x += 0.00001;
    }
}
Console.WriteLine(" ");


Intersection(k1, b1, k2, b2);

Console.WriteLine(" ");

// Использование базовых знаний алгебры

void IntersectionFormulas(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Straight lines straight lines match");
        Console.WriteLine(" ");

    }
    if (k1 == k2)
    {
        Console.Write("Straight lines don't intersect using formulas");
        Console.WriteLine(" ");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
        Console.Write($"Intersection point is found using formulas x = {Math.Round(x, 5)}, y = {Math.Round(y, 5)}");
        Console.WriteLine(" ");
    }
}

IntersectionFormulas(k1, b1, k2, b2);