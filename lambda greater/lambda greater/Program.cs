namespace lambda_greater
{
    internal class Program
    {
        public delegate int greater(int n1, int n2);
        static void Main(string[] args)
        {
            greater f = (n1, n2) => n1 > n2 ? n1 : n2;
            Console.WriteLine("enter the first number");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the greatest of the two numbers is :"+f.Invoke(n1, n2));
        }
    }
}