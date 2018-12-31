using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle(10,20);
            Console.WriteLine(a.Print());

            Square b = new Square(4);
            Console.WriteLine(b.Print());

            Circle c = new Circle(6);
            Console.WriteLine(c.Print());  
            
            Console.ReadLine();
        }
    }
}

abstract class GeometryFigure: IPrint
{
    public abstract double Area();

    public string Print()
    {
        return ToString();
    }
}

class Rectangle : GeometryFigure
{
    public Rectangle(double width,double length)
    {
        this.width = width;
        this.length = length;
    }
    public double width { get; set; }
    public double length { get; set; }

    public override double Area()
    {
        return  length * width;
    }
    public override string ToString()
    {
        return "Прямоугольник с длиной " + width + ", шириной " + length + " и площадью " + Area();
    }
}

class Square : Rectangle
{
    public Square(double width): base(width, width){}
    public override string ToString()
    {
        return "Квадрат со стороной " + width + " и площадью " + Area();
    }
}

class Circle : GeometryFigure
{
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double radius { get; set; }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }
    public override string ToString()
    {
        return "Круг с радиусом " + radius +" и площадью " + Area();
    }
}

interface IPrint
{
    string Print();
}
