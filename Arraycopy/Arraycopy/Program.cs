namespace Arraycopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int[] m = new int[5];
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            Console.WriteLine("original array");
            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("elements [{0}]= {1}", i, j);
            }
            Array.Copy(n, 0, m, 0, 5);
            Console.WriteLine("new array");
            foreach (int res in m)
            {
                Console.WriteLine(res);
            }
            Console.ReadKey();
        }
    }
}