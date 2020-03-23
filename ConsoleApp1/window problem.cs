/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : Window Size Calculator
 * 
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string widthString;
            string heightString;
            double width;
            double height;
            double woodLength;
            double glassArea;

            Console.WriteLine("Please enter width in meters: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("width = " + width);



            Console.WriteLine("Please enter height in meters: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            Console.WriteLine("height = " + height);

            width = double.Parse(widthString);
            height = double.Parse(heightString);
           glassArea= width*height;
            Console.WriteLine("Glass area =" + glassArea + "squared");

            width = double.Parse(widthString);
            height = double.Parse(heightString);
            woodLength = 2 * (width + height);
            Console.WriteLine(" Wood Length = " + woodLength);
        }
    }
}
