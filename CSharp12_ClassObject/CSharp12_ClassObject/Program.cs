using System;

namespace CSharp12_ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("title1", "author1", 12);
            Book book2 = new Book("title2", "author2", 3);
            Console.WriteLine(book.title);
            Console.WriteLine(book.IsMany());

            book2.Pages = 10;
            Console.WriteLine(book2.Pages);

            Console.WriteLine(Book.count); // 0 static variable

            Console.ReadLine();
        }
    }
}