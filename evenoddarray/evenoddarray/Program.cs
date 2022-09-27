namespace evenoddarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int i, j = 0, k = 0, n;

            Console.WriteLine("input the number of elements to be stored");
            n=Convert.ToInt32(Console.ReadLine());

            for(i=0;i<n;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(i=0;i<n;i++)
            {
                if (arr1[i]%2 == 0)
                {
                    arr2[j]= arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            Console.WriteLine("even elements");
            for (i = 0; i < j; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            Console.WriteLine("odd elements");
            for(i=0;i<k;i++)
            {
                Console.WriteLine(arr3[i]);
            }

        }



    }
}