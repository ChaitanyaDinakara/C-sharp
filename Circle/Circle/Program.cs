using System.Runtime.InteropServices;

namespace Circle
{
    internal class Program
    {
        class circle
        {
            double radius = 4,area,perimeter;
            public void Area()
            {
                area = 3.14 * radius * radius;
                perimeter = 2 * 3.14 * radius;
                Console.WriteLine(area);
                Console.WriteLine(perimeter);
            }
        }
        static void Main(string[] args)
        {
            circle c= new circle();
            c.Area();
            
        }
    }
}