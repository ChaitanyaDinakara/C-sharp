namespace anonyprime28
{
    internal class Program
    {
        public delegate void cal(int a);
        static void Main(string[] args)
        {
            
            cal obj = delegate (int a)
            {
                int n = 0;
                for(int i=1;i<=n;i++)
                {
                    if (n % i == 0)
                    {
                        a++;
                    }

                }
                if(a==2)
                {
                    Console.WriteLine("it is a prime number");
                }
                else
                {
                    Console.WriteLine("not a prime number");
                }

            };
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            obj.Invoke(num);
            
        }
    }
}