

public class Shape
{
    public string Color { get; set; }

    public Shape(string color)
    {
        Color = color;
    }

    public virtual double Area()
    {
        return 0;
    }

    public virtual double Perimeter()
    {
        return 0;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string color, double radius)
        : base(color)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(string color, double length, double width)
        : base(color)
    {
        Length = length;
        Width = width;
    }

    public override double Area()
    {
        return Length * Width;
    }

    public override double Perimeter()
    {
        return 2 * (Length + Width);
    }
}

public class Square : Rectangle
{
    public Square(string color, double side)
        : base(color, side, side) 
    {
    }
}

public class Program
{
    public static void Main()
    {
        Shape[] shapes = new Shape[]
        {
            new Circle("Red", 5),
            new Rectangle("Blue", 4, 6),
            new Square("Green", 3)
         };

       
        foreach (Shape shape in shapes){
            Console.WriteLine($"צורה: {shape.GetType().Name}, צבע: {shape.Color}");
            Console.WriteLine($"שטח: {shape.Area():F2}");
            Console.WriteLine($"היקף: {shape.Perimeter():F2}");
            Console.WriteLine();
        }
    }
}
