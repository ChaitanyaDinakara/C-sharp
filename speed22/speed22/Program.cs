namespace speed22
{
    internal class Program
    {
        class Calculate
        {
            static void Main(string[] args)
            {
                float distance;
                float hr, min, sec;
                float timeSec, kph, mph;

                Console.WriteLine("input distance in meter:");
                distance = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("input timeSec in hours");
                hr = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("input timeSec in minutes:");
                min = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("input timeSec in seconds:");
                sec = Convert.ToSingle(Console.ReadLine());

                timeSec = (hr * 3600) + (min * 60) + sec;
                kph = (distance / 1000.0f) / (timeSec / 3600.0f);
                mph = kph / 1.609f;

                Console.WriteLine("speed in kilometer per hour:{0}", kph);
                Console.WriteLine("speed in miles per hour:{0}", mph);
            }
        }
    }
}