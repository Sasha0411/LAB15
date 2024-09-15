using System;

class Point
{
    private int x;
    private int y;

    public Point()
    {
        x = 0;
        y = 0;
    }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void SetCoordinates(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }
    public void Display()
    {
        Console.WriteLine($"Point: ({x}, {y})");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення одного об'єкту і виведення його координат
        Point point1 = new Point(2, 3);
        point1.Display();

        // Створення масиву об'єктів
        Point[] points = new Point[3];
        points[0] = new Point(1, 2);
        points[1] = new Point(3, 4);
        points[2] = new Point(5, 6);

        // Виведення інформації про всі точки масиву
        for (int i = 0; i < points.Length; i++)
        {
            Console.WriteLine($"Point {i + 1}: ({points[i].GetX()}, {points[i].GetY()})");
        }

        // Створення об'єкту, координати якого дорівнюють сумі координат всіх точок
        int sumX = 0, sumY = 0;
        foreach (Point point in points)
        {
            sumX += point.GetX();
            sumY += point.GetY();
        }

        Point sumPoint = new Point(sumX, sumY);
        Console.WriteLine("Sum of all points coordinates:");
        sumPoint.Display();

        // Підрахунок і виведення суми координат всіх точок разом із першою точкою
        int totalX = sumX + point1.GetX();
        int totalY = sumY + point1.GetY();
        Console.WriteLine($"Total sum of coordinates: x = {totalX}, y = {totalY}");
    }
}
