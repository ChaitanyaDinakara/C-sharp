using System.IO;

namespace Txtfile26
{
  public class FileHandling
    {
       public static void Main(string[] args)
        {
            StreamWriter streamWrite = new StreamWriter("C:\\Users\\chaitanya.dinakara\\OneDrive - Entain Group\\Documents\\assignment.txt");
            streamWrite.WriteLine("Today is Monday");
            streamWrite.WriteLine("First day of the week");
            streamWrite.WriteLine("Excited for the week");
            streamWrite.Close();

           StreamWriter sw = File.AppendText("C:\\Users\\chaitanya.dinakara\\OneDrive - Entain Group\\Documents\\assignment.txt");
            {
                sw.WriteLine("Hi this is Chaitanya");
                sw.WriteLine("Nice to meet u");
            }
            sw.Close();
        }
    }
}