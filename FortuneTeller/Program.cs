using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {   ///--------------Part 1 
            Console.Write("What is your first name?: ");
            string firstName = Console.ReadLine();// User's Last Name

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();//----- User's Last name

            Console.Write("What is your age?: ");            
            int userAge = int.Parse(Console.ReadLine());//------User's Age

            Console.Write("How many siblings do you have?: ");
            int numberOfSiblings = int.Parse(Console.ReadLine()); //---User's Amount of Siblings

            
            Console.Write("What is your birth month?: ");
            string birthMonth = Console.ReadLine();//-----User's Birth Month            

            Console.WriteLine("What is your Favorite ROYGBIV color? Type 'HELP' for more info: ");
            string userInputROYGBIV = Console.ReadLine();

            string userHelp = "HELP";
            if (userInputROYGBIV == userHelp)
            {
                 Console.WriteLine("ROYGBIV colors are RED, ORANGE, YELLOW, GREEN, BLUE, INDIGO, INDIGO, VIOLET");
                   
            }
            Console.Write("What is your favorite ROYGBIV color: ");
            string user = Console.ReadLine().ToUpper();
            
            Console.ReadKey();
            //-----------------------------------------------Part 2
            /// if else statment odd or even number
            if (userAge % 2 == 0)// Even number (or Remander) 
            {
                Console.WriteLine("you will retire in 20 years");
            }
            else // if odd number (or remander)  
            {
                Console.WriteLine("you will retire in 15 years");
            }

            //If the user’s number of siblings is 0, then they will live in __(location)
            //, or 1 then they will live in __(location), or 2 then they will live in ___ (location), 
            //or 3 then they will live in ___ (location), or more than 3 then they will live in ____ (location)
            if (numberOfSiblings == 0)
            {
                Console.WriteLine("live in Dakar");
            }
            else if (numberOfSiblings == 1)
            {
                Console.WriteLine("live in Tahiti");
            }
            else if (numberOfSiblings == 2)
            {
                Console.WriteLine("live in Melbourne");
            }
            else if (numberOfSiblings >= 3)
            {
                Console.WriteLine("live in Punta Cana");
            }
            /*
            If the first letter of the user’s birth month can be found in either their first or last name, 
            then they will have $____ in the bank, 
            or if the second letter of the user’s birth month can be found in either the user’s first or last name, 
            then they will have $____ in the bank, 
            or if the third letter of the user’s birth month can be found in either the user’s first or last name, 
            then they will have $____ in the bank. 
            If there are no common letters, then they will have $____ in the bank.
            */
            string birthMonthFirstLetter = birthMonth.Substring(0, 1); 
            string birthMonthSecondLetter = birthMonth.Substring(1, 2);
            string birthMonthThirdLetter = birthMonth.Substring(2, 3);
            //Console.WriteLine(BirthMonthFirstLetter);
            //Console.WriteLine(BirthMonth);
            //-----First Letter of the user's birth month

            //switch (BirthMonthFirstLetter)

            string fullName = (firstName + lastName);
            string bankTotal = "";

            if (fullName.IndexOf(birthMonthFirstLetter) != -1)
            {
                bankTotal = "$50,000";

            }
            else if (fullName.IndexOf(birthMonthSecondLetter) != -1)
            {
                bankTotal = "$80,000";
            }

            else if (fullName.IndexOf(birthMonthThirdLetter) != -1)
            {
                bankTotal = "$35,000";
            }

            else
            {
                bankTotal = "$7,000";
            }

            /*Console.WriteLine("What is your Birth Month?: ");
            //string birthMonth = Console.ReadLine();

            string[] birthMonthLetter = new string[3];
            birthMonthLetter[1] = "$1000";
            birthMonthLetter[2] = "$2000";
            //birthMonthLetter[3] = "$3000";

            //string birthMonthFirstLetter = birthMonth.IndexOf("1" );
            Console.WriteLine(birthMonthFirstLetter);*/

            //string colorTransportation = ""; Will probably use later to convert over 

            switch (userInputROYGBIV)
            {
                case "RED":
                    Console.WriteLine("You will have a Maserati car");

                    break;
                case "ORANGE":
                    Console.WriteLine("You will have a Mini Coop");
                    break;
                case "YELLOW":
                    Console.WriteLine("You will be riding on the RTA bus");
                    break;
                case "GREEN":
                    Console.WriteLine("You will ride a camel");
                    break;
                case "BLUE":
                    Console.WriteLine("You will have a Magic Carpet");
                    break;
                case "INDIGO":
                    Console.WriteLine("You will be riding in Mermaidman and Barnacleboy's Invisible Boatmobile");
                    break;
                case "VIOLET":
                    Console.WriteLine("You will have a go-kart");
                    break;
            }
            //--------Part 3 
            Console.WriteLine(firstName, lastName, userAge, numberOfSiblings,bankTotal);
            Console.ReadKey();
        }
    }
}
