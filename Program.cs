using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, what is your name?");  //displays question
            string name = Console.ReadLine();  //creates string variable with value given by user
            Console.WriteLine("How is your day? Please answer with one word.");  //displays question
            string day = Console.ReadLine();  //creates string variable with value given by user
            string dayUpper = day.ToUpper();   //variable that converts another variable to uppercase
            Console.WriteLine("So " + name + ", your day is " + dayUpper + ", why is that?");  //concatenated strings
            Console.ReadLine();  //any user input
            StringBuilder sb = new StringBuilder();  //Paragraph built line by line using stringbuilder
            sb.AppendLine(name + " I hope you know that your are awesome and worthy of love.");
            sb.AppendLine("Sometimes we forget that we are unique and we do not need to compare ourselves to others.");
            sb.AppendLine("Learn to love yourself because you are the only one who will always be there for you.");
            Console.WriteLine(sb);  //Displays paragraph built using stringbuilder
            Console.ReadLine() ;    
        }
    }
}
