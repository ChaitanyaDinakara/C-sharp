namespace Student26
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> stu = new Dictionary<int, string>();
            {
                try
                {
                    stu.Add(1234, "David");
                    stu.Add(2345, "Kevin");
                    stu.Add(7896, "Mark");
                    stu.Add(3456, "Gamora");
                    stu.Add(3293, "Vishal");
                    stu.Add(3263, "Chaithu");
                    stu.Add(3263, "Chaithu");
                    stu.Add(4567, "Kiran");

                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                foreach(KeyValuePair<int,string> keyValuePair in stu)
                {
                    Console.WriteLine(keyValuePair.Key.ToString() + " " + keyValuePair.Value);
                }
            }
        }
    }
}