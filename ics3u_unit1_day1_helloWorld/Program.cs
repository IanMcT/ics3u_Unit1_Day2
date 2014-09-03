using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Program: Hello World
 * Author:  
 * Date: Sept 2, 2014
 * Simple program to demo how to create a console program.
 */
namespace ics3u_unit1_day1_helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the name from the user
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            //ReadLine keeps the program running until
            //the user enters something - otherwise
            //it closes immediately
            Console.ReadLine();
        }
    }
}
