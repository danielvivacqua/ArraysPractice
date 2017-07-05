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
            //int[] myFirstArray;
            ////declaring and initializing a second array
            //string[] myStringArray = { "First", "second", "third", "fourth" };
            ////declare and initialize a char array with the letters of your last name
            //char[] myName = { 'v', 'i', 'v', 'a', 'c', 'q', 'u', 'a' };
            ////I want my console to print three elements of my array
            //Console.WriteLine(myName[0]);
            //Console.WriteLine(myName[3]);
            //Console.WriteLine(myName[1]);


            //Create the following arrays and print using the correct index numbers:
            //Array of Top 10 Vacation spots
            //print the first and last vacation spots
            //string[] vacationSpots = { "Japan", "Ireland", "Korea", "Iceland", "Cooperstown", "Australia", "Alabama", "Key West", "Jamaica", "Buffalo" };
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]);

            //Array of the ages of 3 children you know
            //print each child's age
            //int[] childrensAges = { 13, 1, 6 };
            //Console.WriteLine(childrensAges[0]);
            //Console.WriteLine(childrensAges[1]);
            //Console.WriteLine(childrensAges[2]);

            //Array of GPA's on a 4.0 scale of 8 students - you don't have to print

            //Array of the First Letter of 4 of your classmates' names who are sitting near you
            //print all four on the same line
            //char[] classFirstLetters = { 'j', 'd', 'j', 'n' };
            //Console.WriteLine(classFirstLetters);
            //Console.Write(classFirstLetters[0]);
            //Console.Write(classFirstLetters[1]);
            //Console.Write(classFirstLetters[2]);
            //Console.Write(classFirstLetters[3]);

            //Console.WriteLine("\n{0}, {1}, {2}, {3}", classFirstLetters[0], classFirstLetters[1], classFirstLetters[2], classFirstLetters[3]);

            //dataType[] nameOfArray = new dataType[#ofElements];
            //int[] numberOfSeats = new int[21];
            //string[] studentsInClass = new string[21];

            ////nameOfArray[index] = Element;
            //studentsInClass[0] = "Jordan";

            //Console.WriteLine("Please enter in the name of the next student.");
            //studentsInClass[1] = Console.ReadLine();
            //Console.WriteLine("The student in the second seat is {0}.", studentsInClass[1]);

            ////Ask user for input
            //Console.WriteLine("Please enter the age of the person in the first seat.");
            ////Create a new int array with 21 spots and call it ageOfStudentsInClass
            //int[] ageOfStudentsInClass = new int[21];
            ////Assign the value of the int at the 0 index of ageOfStudentsInClass to ...
            ////... the user's input converted into an int
            //ageOfStudentsInClass[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("The age of the student in the first seat is " + ageOfStudentsInClass[0]);
            ////Create a new string variable and set it equal to the int at the index of 0 ...
            ////and convert it into a string
            //string firstIndex = ageOfStudentsInClass[0].ToString();

            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick Fil-A" };
            //Console.WriteLine(restaurantsInMall.Length);

            ////For review
            ////Declare and not initialize
            //int[] myIntArrayAgain;
            ////Declare and initialize an array when I know the elements
            //char[] lettersInFirstName = { 'D', 'a', 'n', 'i', 'e', 'l' };
            ////Declare and initialize an array when I DON'T know the elements but I know how many
            //string[] variableName = new string[42];

            //To practice using .Length, create a char array of the letters in your middle name
            //... and print the number of char's to the Console.
            //char[] middleName = { 'R', 'o', 'b', 'e', 'r', 't' };
            //Console.WriteLine(middleName.Length);

            //Declare and initialize a string array.
            //Using the Length property, print the SECOND TO LAST element in the array

            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick Fil-A" };
            //int numRest = restaurantsInMall.Length;
            //Console.WriteLine(restaurantsInMall[numRest - 2]);

            //IndexOf is a method used to search an array for a specified value and returns
            //the index position of the first matching value found.
            //int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            //Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));
            ////LastIndexOf is a method used to search an array for a specified value and returns
            ////the index position of the LAST matching value found.
            //Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));

            //Reverse Method
            int[] palindromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(palindromeNumbers[0]);
            Console.WriteLine(palindromeNumbers[2]);
            Array.Reverse(palindromeNumbers);
            Console.WriteLine(palindromeNumbers[0]);
            Console.WriteLine(palindromeNumbers[2]);




        }
    }
}
