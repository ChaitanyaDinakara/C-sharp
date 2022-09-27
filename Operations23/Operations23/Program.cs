namespace Operations23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to find square root
            double n;
            int u, v, g, f;
            Console.WriteLine("enter a number to find square root");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("square root is:" + Math.Sqrt(n));

            //to add two numbers
            Console.WriteLine("enter the 1st number to add");
                u = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number to add");
                v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(u+v);

            //to subtract two numbers
            Console.WriteLine("enter the 1st number to subtract");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 2nd number to subtract");
            f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(g - f);

            //to multiply two numbers
            double x, y;
            Console.WriteLine("enter the 1st number to multiply");
            x= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the 2nd number to multiply");
            y= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x*y);

            Console.WriteLine("To demonstrate divide by zero exception");
            try
            {
                int a = 23, b = 0, c = 0;
                c = a / b;
                Console.WriteLine(c);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}