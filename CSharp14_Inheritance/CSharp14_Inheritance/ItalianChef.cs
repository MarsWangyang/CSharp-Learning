using System;
namespace CSharp14_Inheritance
{
    public class ItalianChef : Chef // Inheritance
    {
        public ItalianChef()
        {
        }

        public void MakePasta()
        {
            Console.WriteLine("Make Pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }

        // must be a virtual or abstract method to be overrided 
        //public override void MakeSalad() 
        //{
        //    Console.WriteLine("The ItalianChef make Salad");
        //}
    }
}

