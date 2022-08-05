using System;
namespace CSharp12_ClassObject
{
    public class Book
    {
        public string title;
        public string author;
        private int pages;
        public static int count = 0;

        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public bool IsMany()
        {
            if (pages > 5)
            {
                return true;
            }
            return false;
        }

        public int Pages
        {
            get { return pages; }
            set
            {
                if (value == 10 || value == 20 || value == 30)
                {
                    pages = value;
                }
            }
        }
    }
}

