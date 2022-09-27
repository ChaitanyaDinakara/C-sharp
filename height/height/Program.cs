namespace height
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float height;
            Console.Write("enter the height (in cm)");
            height = int.Parse(Console.ReadLine());


            if (height < 135)
                Console.WriteLine(" the person is short");
            else if ((height > 135) && (height < 180))
                Console.WriteLine("the person is medium height");
            else if (height > 180)
                    Console.WriteLine("the person is tall");
            }
        }
    }
