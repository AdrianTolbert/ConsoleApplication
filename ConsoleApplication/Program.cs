using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Adrian Tolbert"; 
            string location = "Rexburg, Idaho";

            Console.WriteLine($"Hello my name is {name}");
            Console.WriteLine($"My location is {location}");

            /*Date*/
            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is: {currentDate.ToString("d")}");

            /* Code from Textbook*/
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            /*Christmas*/
            var christmasDay = new DateTime(2020, 12, 25);
            Console.WriteLine($"Christmas is on{christmasDay}");

            var timeSpan = christmasDay - currentDate;
            var numberOfDaysUntilChristmas = timeSpan.Days;
            Console.WriteLine($"The number of days until Christmas: {numberOfDaysUntilChristmas}");

            Console.Write("Please enter a width(in meters): ");
            widthString = Console.ReadLine(); 
            width = double.Parse(widthString);

            Console.Write("Please enter a height(in meters): ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);


            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);


            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();

            

        }
    }
}
