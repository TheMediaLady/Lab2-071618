using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_071618
{
    class Program
    {
        static void Main(string[] args)
        {

            string Continue = "y";
            
            while (Continue == "y")
            {
                Console.Write("Enter Length: ");
                string lengthString = Console.ReadLine();
                Console.Write("Enter Width: ");
                string widthString = Console.ReadLine();
                decimal length = decimal.Parse(lengthString);
                decimal width = decimal.Parse(widthString);
                decimal area = length * width;
                decimal perimeter = (length * 2) + (width * 2);
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");
              
                Console.Write("Continue? Y/N: ");
                
                Continue = Console.ReadLine();
                Continue = Continue.ToLower();
            }
            
            
            
        }
    }
}
