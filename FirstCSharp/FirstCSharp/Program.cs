using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object of BookClass made with passing parameters to constructor
            //Getters and Setters used to encapsulate the variable "Rating"
            BookClass book1 = new BookClass("Harry Potter", "JK Rowling", 45.5f, "Rate");
            Console.WriteLine(book1.Rating);
            BookClass book2 = new BookClass("Hamlet", "William Shakespeare", 20.5f, "G");
            Console.WriteLine(book2.Rating);

            //object of class need not be created since the method is 'static'
            BookClass.DisplayProgram("Library");

            //object cannot be created since the whole class is 'static'. But methods can be called using class name.
            SomeTools.Tool1();

            Console.ReadLine();
        }
    }
}
