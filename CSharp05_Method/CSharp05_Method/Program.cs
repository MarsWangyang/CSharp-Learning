namespace CShapr05_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.SayHi("Mars");
            SayHiStatic("Tom");
            Console.ReadLine();
        }

        public void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static void SayHiStatic(string name)
        {
            Console.WriteLine("Hello static " + name);
        }

    }
}
