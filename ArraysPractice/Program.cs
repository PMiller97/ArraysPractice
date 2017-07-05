using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an array without initializing
            int[] myFirstArray;
            //declaring and initialzing a second array
            string[] myStringArray = { "First", "second", "third", "fourth" };

            //declare and intitalizing a char ray with the letters of your last name
            char[] myLastName = { 'm', 'i', 'l', 'l', 'e', 'r' };
            //i want my console to print 3 elements of my array
            Console.WriteLine(myLastName[0]);
            Console.WriteLine(myLastName[3]);
            Console.WriteLine(myLastName[5]);

            //create the following arrays and print using the correct index numbers:
            //Array of the top 10 vacation spots
            //print the first and last vacation spots
            //Array of the ages of 3 children that you know
            //print each childs age
            //Array of the GPS's on a 4.0 scale of 8 students - you don't have to print
            //Array of the First Letter of 4 of your classmate's names who are sitting near you
            //print all four on the same line

            string[] vacationSpots = { "California", "Hawaii", "Cancun", "Paris", "Mexico", "Costa Rico", "Dominican Republic", "Norway", "Germany", "Cuba" };
            Console.WriteLine(vacationSpots[0]);
            Console.WriteLine(vacationSpots[9]);

            int[] childrenAge = { 4, 6, 8 };
            Console.WriteLine(childrenAge[0]);
            Console.WriteLine(childrenAge[1]);
            Console.WriteLine(childrenAge[2]);

            double[] gpa = { 2.0, 2.5, 2.8, 3.0, 3.2, 3.4, 3.5, 3.9 };

            char[] firstLetter = { 'a', 'b', 'h', 'i' };
            Console.WriteLine(firstLetter);
            ///or
            Console.WriteLine("{0}, {1}, {2}, {3}", firstLetter[0], firstLetter[1], firstLetter[2], firstLetter[3]);
            //or
            Console.Write(firstLetter[0]);
            Console.Write(firstLetter[1]);
            Console.Write(firstLetter[2]);
            Console.Write(firstLetter[3]);








        }
    }
}
