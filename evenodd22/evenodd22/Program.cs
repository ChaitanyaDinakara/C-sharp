namespace evenodd22
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers :");
            int n1, n2;
            bool botheven;
            Console.WriteLine("input the first number n1:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the second number n2:");
            n2= Convert.ToInt32(Console.ReadLine());

            botheven =((n1%2 == 0)&& (n2%2==0))? true : false;

            Console.WriteLine( botheven ? "botheven numbers are even" : "both numbers are odd");


        }
    }
}