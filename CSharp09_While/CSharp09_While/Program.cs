namespace CSharp09_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 6;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.WriteLine("=======");
            int index1 = 6;
            do
            {
                Console.WriteLine(index1);
                index1++;
            } while (index1 <= 5);
        }
    }
}