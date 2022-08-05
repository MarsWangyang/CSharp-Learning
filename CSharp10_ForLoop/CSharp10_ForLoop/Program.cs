namespace CSharp10_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int k = 0;
            int a, b;
            int[] arr = { 4, 5, 6, 7, 8, 9 };
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=======");
            for (int i = 1; i <= 5; i++)
            {
                a = j++;
                b = j++;
                Console.WriteLine(a + " " + b);

            }
            Console.WriteLine("=======");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}