namespace Genericclass26
{
    public class Program
    {
        public void GenericClassMethods<T1,T2,T3>(T1 id, T2 name, T3 status)
        {
            Console.WriteLine(id+ "," + name + "," +status);
        }
    
        
        public static void Main(string[] args)
        {
                Program p = new Program();
            p.GenericClassMethods<int, string, char>(12, "Chaithu", 'P');
            p.GenericClassMethods<int, string, char>(14, "Prasanth", 'N');
            p.GenericClassMethods<int, string, char>(12, "Priya", 'P');
            p.GenericClassMethods<int, string, char>(12, "Preethi", 'N');
            p.GenericClassMethods<int, string, char>(12, "Gomathi", 'P');

        }
    }
}