using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cesar Roncancio
//CISS201
//Agile Development
//9/13/2020

namespace dropbox02
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome text and text for client
            Console.WriteLine("Welcome to Cesar's Pizzeria!");
            Console.WriteLine("Enter your pizza's radius in inches:");
            //saving client input in radius variable
            int radius = Convert.ToInt32(Console.ReadLine());
            //calculating pizza's area
            double area = 3.14 * Math.Pow(radius, 2);
            //calculating number of slices if they are at least 15 square inches
            double slices = area / 15;
            //displaying number of slices
            Console.WriteLine("Number of slices: " + slices);
            Console.Read();

                    }
    }

}
