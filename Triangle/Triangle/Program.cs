namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("enter the 1st side of triangle");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 2nd side of trianle");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third side of the triangle");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("the triangle is equilateral ");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("the triangle is isosceles");
            }
            else
            {
                Console.WriteLine("The triangle is scalene ");
            }
        }
    }
}