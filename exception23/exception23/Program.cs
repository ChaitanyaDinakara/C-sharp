namespace exception23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "3.5";
                int a = int.Parse(str);//format exception is thrown as the input is other than an integer
            }
            catch
            {
                Console.WriteLine("format exception");
            }
        }
    }
}