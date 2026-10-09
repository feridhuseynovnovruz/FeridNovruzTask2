using System;
using System.Collections.Generic;

interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

class Circle : IShape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return 3.14 * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * 3.14 * Radius;
    }
}

class Rectangle : IShape
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

class Triangle : IShape
{
    public double A;
    public double B;
    public double C;

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double CalculateArea()
    {
        return (A * B) / 2;
    }

    public double CalculatePerimeter()
    {
        return A + B + C;
    }
}
class ShapeHelper
{
    public double CalculateArea(double radius)
    {
        return 3.14 * radius * radius;
    }

    public double CalculateArea(double width, double height)
    {
        return width * height;
    }
}
class Program
{
    static void Main()
    {
        List<IShape> shapes = new List<IShape>();
        shapes.Add(new Circle(5));
        shapes.Add(new Rectangle(4, 6));
        shapes.Add(new Triangle(3, 4, 5));

        foreach (IShape shape in shapes)
        {
            Console.WriteLine(shape.CalculateArea());
            Console.WriteLine(shape.CalculatePerimeter());

        }
    }
}