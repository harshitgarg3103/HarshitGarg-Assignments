namespace Assignment_3
{
    internal class q2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER SENTENCE: ");
            string s = Console.ReadLine();
            string[] str = s.Split(' ');
            int[] freq = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
                freq[i] = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ".")
                    continue;
                int counter = 1;
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        str[j] = ".";
                        counter++;
                    }
                }
                freq[i] = counter;
            }
            Console.WriteLine("Frequency of each word is: ");
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ".")
                {
                    Console.WriteLine(str[i] + "->" + freq[i]);
                }
            }
        }
    }
}