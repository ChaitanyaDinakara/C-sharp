namespace mergearray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 90, 91, 92, 94, 95 };
            int[] arr2 = { 96, 97, 98, 99, 100 };

            Console.WriteLine("array 1 elements");
            foreach(int ele in arr1)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("array 2 elements");
            foreach(int ele in arr2)
            {
                Console.WriteLine(ele);
            }
            var myList = new List<int>();
            myList.AddRange(arr1);
            myList.AddRange(arr2);
            int[] arr3 = myList.ToArray();
            Console.WriteLine("arrays combined");
            foreach (int ele in arr3)
            {
                Console.WriteLine(ele);
            }
        }
    }
}