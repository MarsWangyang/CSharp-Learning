using System;
//using System. 





namespace CSharpOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string phrase = "String data type";
            char grade = 'A';
            int age = 10;

            Console.WriteLine("Mars\nWang");
            Console.WriteLine("Mars\" Wang"); // show quotation mark
            string appendString = "Mars Wang" + " cool";
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower()); 
            Console.WriteLine(phrase.Contains("String")); // true
            Console.WriteLine(phrase[0]); // S
            Console.WriteLine(phrase.IndexOf('t')); // 1
            Console.WriteLine(phrase.Substring(2, 4)); // ring
            Console.WriteLine(8 % 5); // 3 mod
            Console.WriteLine(3.4 + 5); // 7.4
            Console.WriteLine(5 / 2); // 2 -> integer back
            Console.WriteLine(5 / 2.0); // 2.5 -> double back;

            Console.WriteLine(Math.Abs(-200)); // 200
            Console.WriteLine(Math.Pow(3, 2)); // 9
            Console.WriteLine(Math.Sqrt(36)); // 6
            Console.WriteLine(Math.Max(3, 10)); // 10, which one is bigger
            Console.WriteLine(Math.Round(4.3)); // 4
            Console.WriteLine(Math.Round(4.6)); // 5

            // User Input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine(); // enter the text from user and store to variable
            Console.Write("Enter your age: ");
            string age1 = Console.ReadLine();
            Console.WriteLine("Hello " + name + ". You are "+ age1 + " years old." );

            Console.ReadLine();
        }
    }
}