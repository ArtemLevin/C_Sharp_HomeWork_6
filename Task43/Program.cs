// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Первый способ: метод перебора

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
    Console.Write($"The equation of the second line y2 = {k2}*x + {b2} ");
    Console.WriteLine(" ");
    Console.WriteLine(" ");

    double x = -1000;
    double y1;
    double y2;
    double delta;

    while (x < 1000)
    {
        y1 = k1 * x + b1;
        y2 = k2 * x + b2;
        delta = Math.Abs(y1 - y2);

        if (k1 == k2 & b1 != b2)
        {
            Console.WriteLine("Straight lines don't intersect (using brute force)");
            break;
        }
        if (k1 == k2 & b1 == b2)
        {
            Console.WriteLine("Straight lines match (using brute force)");
            break;
        }
        if (delta < 0.0001)
        {
            Console.Write($"Intersection point is found (using brute force) x = {Math.Round(x, 2)}, y = {Math.Round(y1, 2)}");
            Console.WriteLine(" ");
            break;
        }
        x += 0.00001;
    }
}
Console.WriteLine(" ");


Intersection(k1, b1, k2, b2);

Console.WriteLine(" ");

// Второй сопособ: использование базовых знаний алгебры

void IntersectionFormulas(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Straight lines match (using formulas)");
        Console.WriteLine(" ");
    }
    if (k1 == k2 && b1 != b2)
    {
        Console.Write("Straight lines don't intersect (using formulas)");
        Console.WriteLine(" ");
    }
    if (k1 != k2 && b1 != b2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
        Console.Write($"Intersection point is found (using formulas) x = {Math.Round(x, 2)}, y = {Math.Round(y, 2)}");
        Console.WriteLine(" ");
    }
}

IntersectionFormulas(k1, b1, k2, b2);
Console.WriteLine(" ");


// Третий способ: при помощи двумерных массивов

void Inter(double k1, double b1, double k2, double b2)
{
    double x = -10;
    double y1;
    double y2;
    int i = 0;


    int numberOfDots = 20000;

    if (k1 == k2 & b1 != b2)
    {
        Console.WriteLine("Straight lines don't intersect (using brute force)");
            
    }
    if (k1 == k2 & b1 == b2)
    {
        Console.WriteLine("Straight lines match (using brute force)");
            
    }

    double[,] lineOneArray = new double[2, numberOfDots];
    double[,] lineTwoArray = new double[2, numberOfDots];

    while (i < numberOfDots)
    {
        y1 = k1 * x + b1;
        lineOneArray[0, i] = Math.Round(x, 2);
        lineOneArray[1, i] = Math.Round(y1, 2);

        y2 = k2 * x + b2;
        lineTwoArray[0, i] = Math.Round(x, 2);
        lineTwoArray[1, i] = Math.Round(y2, 2);

        x += 0.001;
        i++;
    }

    int indexOne = 0;
    int indexTwo = 0;

    while (indexOne < numberOfDots)
    {
        indexTwo = 0;
        while (indexTwo < numberOfDots)
        {
            if (lineOneArray[0, indexOne] == lineTwoArray[0, indexTwo] && lineOneArray[1, indexOne] == lineTwoArray[1, indexTwo])
            {
                Console.Write($"Intersection point is found (using arrays) x = {lineOneArray[0, indexOne]}, y = {lineOneArray[1, indexOne]}");
                Console.WriteLine(" ");
                break;
            }
            indexTwo++;   
        }
        indexOne++;
    }
    
}

Inter(k1, b1, k2, b2);