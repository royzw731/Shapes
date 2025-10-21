using System.Formats.Asn1;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapess = new Shape[4];
            shapess[0] = new Shape("blue");
            shapess[1] = new Rectangle("red", 2, 4);
            shapess[2] = new Square("yellow", 3);
            shapess[3] = new Circle(5, "green");
            for (int i = 0; i < shapess.Length; i++)
            {
                Console.WriteLine("area: " + shapess[i].Area());
                Console.WriteLine("perimeter: " + shapess[i].Perimeter());
            }





        }
    }
}