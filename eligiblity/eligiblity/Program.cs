namespace eligiblity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MarinMath, MarinPhy, MarinChem;
            Console.WriteLine("enter the marks in maths:");
            MarinMath = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the marks in physics:");
            MarinPhy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the marks in Chemistry");
            MarinChem=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total marks in physics,maths,chemistry{0}",+MarinMath,+MarinPhy,+MarinChem);
            Console.WriteLine("Total marks in physics and maths {0}", +MarinPhy, +MarinMath);


            if (MarinMath >= 65)
                if (MarinPhy >= 55)
                    if (MarinChem >= 50)
                        if (MarinMath + MarinPhy + MarinChem > 180 || MarinMath + MarinPhy > 140)
                            Console.WriteLine("The candidate is eligible");
                        else
                            Console.WriteLine("the candidate is not eligible");
        

            
            
        }
    }
}