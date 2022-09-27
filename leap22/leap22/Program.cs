namespace leap22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentyear;

            Console.WriteLine("input the year");
            currentyear=Convert.ToInt32(Console.ReadLine());

            if ((currentyear % 400) == 0)
                Console.WriteLine("{0} is a leap year", +currentyear);
            else if ((currentyear % 100) == 0)
                Console.WriteLine("{0} not a leap year", +currentyear);
            else if ((currentyear % 4) == 0)
                Console.WriteLine("{0} is a a leap year", +currentyear);
            else
                Console.WriteLine("{0} not a leap year", +currentyear);
        }
    }
}