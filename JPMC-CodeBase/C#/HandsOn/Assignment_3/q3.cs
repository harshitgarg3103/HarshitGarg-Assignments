namespace Assignment_3
{
    internal class q3
    {
        public static int s(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER SIZE OF ARRAY: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of array elements is {0}", q3.s(arr));
        }
    }
}