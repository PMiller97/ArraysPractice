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
            ////declaring an array without initializing
            //int[] myFirstArray;
            ////declaring and initialzing a second array
            //string[] myStringArray = { "First", "second", "third", "fourth" };

            ////declare and intitalizing a char ray with the letters of your last name
            //char[] myLastName = { 'm', 'i', 'l', 'l', 'e', 'r' };
            ////i want my console to print 3 elements of my array
            //Console.WriteLine(myLastName[0]);
            //Console.WriteLine(myLastName[3]);
            //Console.WriteLine(myLastName[5]);

            ////create the following arrays and print using the correct index numbers:
            ////Array of the top 10 vacation spots
            ////print the first and last vacation spots
            ////Array of the ages of 3 children that you know
            ////print each childs age
            ////Array of the GPS's on a 4.0 scale of 8 students - you don't have to print
            ////Array of the First Letter of 4 of your classmate's names who are sitting near you
            ////print all four on the same line

            //string[] vacationSpots = { "California", "Hawaii", "Cancun", "Paris", "Mexico", "Costa Rico", "Dominican Republic", "Norway", "Germany", "Cuba" };
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]);

            //int[] childrenAge = { 4, 6, 8 };
            //Console.WriteLine(childrenAge[0]);
            //Console.WriteLine(childrenAge[1]);
            //Console.WriteLine(childrenAge[2]);

            //double[] gpa = { 2.0, 2.5, 2.8, 3.0, 3.2, 3.4, 3.5, 3.9 };

            //char[] firstLetter = { 'a', 'b', 'h', 'i' };
            //Console.WriteLine(firstLetter);
            /////or
            //Console.WriteLine("{0}, {1}, {2}, {3}", firstLetter[0], firstLetter[1], firstLetter[2], firstLetter[3]);
            ////or
            //Console.Write(firstLetter[0]);
            //Console.Write(firstLetter[1]);
            //Console.Write(firstLetter[2]);
            //Console.Write(firstLetter[3]);



            ////dateType[] nameOfArray = new dataType[#ofElements];
            //int[] numberOfSeats = new int[21];
            //string[] studentsInClass = new string[21];

            ////nameOfArray[index] = Element;
            //studentsInClass[0] = "Jordan";

            //Console.WriteLine("Please enter in the name of the next student.");
            //studentsInClass[1] = Console.ReadLine();
            //Console.WriteLine("The student in the second seat is {0}.", studentsInClass[1]);

            ////ask user for unput
            //Console.WriteLine("Please enter the age of the person in the first seat.");
            ////create a new int array with 21 spots and call it ageOfStudentsInClass
            //int[] ageOfStudentsInClass = new int[21];
            ////assign the value of the int at the 0 index of ageOfStudentsInClass to....
            ////....the user's input converted into an int
            //ageOfStudentsInClass[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("The age of the student in the first seat is " + ageOfStudentsInClass[0]);
            ////create a new string vaiable and set it equal to the int at the index of 0....
            ////and convert it into a string
            //string firstIndex = ageOfStudentsInClass[0].ToString();


            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick-Fil-A" };
            //Console.WriteLine(restaurantsInMall.Length);

            ////For review
            ////Declare and not initailize
            //int[] myIntArrayAgain;
            ////Declare and itialize an array when I know the elements
            //char[] lettersInFirstName = { 'p', 'a', 'i', 'g', 'e' };
            ////Declare and initialize an array when I don't know the elements
            //string[] variableName = new string[42];

            ////To practice using .Length, create a char array of the letters in your middle name
            ////...and print the number of char's to the Console.
            //char[] lettersInMiddleName = { 'm', 'a', 'r', 'i', 'e' };
            //Console.WriteLine(lettersInMiddleName.Length);

            ////Declare and initialize a string array.
            ////Using the Length property, print the SECOND TO LAST element in the array
            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick-Fil-A" };
            //int numRest = restaurantsInMall.Length;
            //Console.WriteLine(restaurantsInMall[numRest - 2]);
            ////restarauntsInMall.Lenght = 5 - 2
            ////restarauntsInMall[3]

            ////IndexOf is a method used to search an array for a specified value and returns
            ////the index position of the first matching value found.
            //int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            //Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));
            ////LastindexOf is a method used to search an array for a specified value and returns
            ////the index position of the LAST matching value found.
            //Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));

            ////Reverse method
            //int[] palindromeNumbers = {1, 2, 3, 4, 5, 6, 7};
            //Console.WriteLine(palindromeNumbers[0]); //print was 1
            //Array.Reverse(palindromeNumbers);
            //Console.WriteLine(palindromeNumbers[0]); //print was 7 because it was reversed
            //Console.WriteLine(palindromeNumbers[2]); //print was 5

            ////Sort
            ////Will sort numbers in an array from lowest to highest
            ////Will sort char's and strings in alphabetical order from A-Z
            //string[] powerRangers = { "Green", "Yellow", "Pink", "Blue", "Red", "Black" };
            //Console.WriteLine(powerRangers[0]); //print was Green
            //Array.Sort(powerRangers);
            //Console.WriteLine(powerRangers[0]); //print was Black because it was sorted


            //Declare and initialize a string array of first names.Choose a name to find and print the IndexOf.
            //Create an array of lucky numbers. Each number should repeat at least once.Choose a lucky number, find and print the last index of it.
            //Create an array of alphabet characters. Print the first index of the array.Now reverse the array and print the first index.
            //Create an array of student names in random order. Order the students’ names using the sort method.Print the first and last students’ names.
            //Ask 10 people for their favorite numbers and create an array of those numbers.Order the numbers using the sort method.Print the first and last numbers.
            string[] namesFirst = { "Kelly", "Josh", "Jeremy", "Brenden", "Carla"};
            Console.WriteLine(Array.IndexOf(namesFirst, "Jeremy"));
            //print = 2
            //"Jeremy is the second index in the sequence

            int[] luckyNumbers = { 3, 7, 13, 7, 3, 13 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 7));
            //print 3
            //the last time you see 7 in this sequence is the third index

            char[] alphabetCharacters = { 'z', 'y', 'x', 'w', 't', 'u', 'v' };
            Console.WriteLine(alphabetCharacters[0]);
            Array.Reverse(alphabetCharacters);
            Console.WriteLine(alphabetCharacters[0]);
            //print = "z" first letter in sequence
            //print = "v" (reversed) last letter in the sequence

            string[] nameStudents = { "Mike", "Bob", "Frank", "Jay", "Daniel", "Jessica" };
            Console.WriteLine(nameStudents[0]);
            Array.Sort(nameStudents);
            Console.WriteLine(nameStudents[0]);
            //print = "Mike" first name in the sequence
            //print = "Bob" sorted the name alphabetical order

            int[] favNumbers = { 21, 4, 67, 83, 10, 123, 1, 16, 185, 20 };
            Console.WriteLine(favNumbers[0]);
            Array.Sort(favNumbers);
            Console.WriteLine(favNumbers[0]);
            //print = 









        }
    }
}
