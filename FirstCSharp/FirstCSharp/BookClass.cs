using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp
{
    class BookClass
    {
        string title;
        public string author;
        public float price;
        public string rating; //M, R, PG, G

        public BookClass(string title = "no name", string author = "no author", float price = 0.0f, string rating = "NR")
        {
            this.title = title;
            this.author = author;
            this.price = price;
            Rating = rating;
        }

        //Encapsulation for the variable Rating
        public string Rating
        {
            //returns the value using getter
            get { return rating; }
            set
            {
                // Checking if the passed value is one of the acceptable one
                if(value == "M" || value == "R"|| value == "PG"|| value == "G")
                {
                    rating = value;
                }
                else 
                {
                    rating = "NR";
                }

            }
        }

        // static method created with 'static' keyword
        public static void DisplayProgram(string ProgramName)
        {
            Console.WriteLine("This is a " + ProgramName);
        }
    }
}
