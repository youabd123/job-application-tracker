using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciperDemo.Polymorphism;

public abstract class Shape
{
    public abstract double Area();

    public virtual void Draw()
    {
        Console.WriteLine($"Ritar form med area {Area():0.##}");
    }
}

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area() => Math.PI * Radius * Radius;

    public override void Draw()
    {
        Console.WriteLine($"Ritar cirkel (r={Radius}) area={Area():0.##}");
    }
}

public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area() => Width * Height;

    public override void Draw()
    {
        Console.WriteLine($"Ritar rektangel ({Width}x{Height}) area={Area():0.##}");
    }
}
