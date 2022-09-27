namespace replace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            char[] arr;
            int i, l;
            l = 0;
            char ch;
            Console.WriteLine("enter a string");
            str= Console.ReadLine();
            l = str.Length;
            arr = str.ToCharArray(0,l);

            for (i = 0; i < l; i++)
            {
                ch=arr[i];
                if (Char.IsLower(ch))
                    Console.Write(Char.ToUpper(ch));
                else
                    Console.Write(Char.ToLower(ch));
            }
            
        }
        
    }
}