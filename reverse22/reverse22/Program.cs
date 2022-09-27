using System;

namespace reverse22
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            char a, b, c;
            Console.Write("input letter: ");
            a = Convert.ToChar(Console.ReadLine());

            Console.Write("input letter: ");
            b = Convert.ToChar(Console.ReadLine());

            Console.Write("input letter: ");
            c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0},{1},{2}", c, b, a);

        }
    }
}