namespace stringreverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int l = 0;
            
            Console.WriteLine("input the string");
            str = Console.ReadLine();

            l = str.Length - 1;
            Console.WriteLine("the characters of the string in reverse");
            while(l>=0)
            {
                Console.WriteLine("{0}", str[l]);
                l--;
            }
            Console.WriteLine("\n\n");
        }
    }
}