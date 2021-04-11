using System;

namespace Assignment_1_Descision_Making
{
    class Program
    {
        static void Main(string[] args)
        {   //Application prompts user for an interger between 1 - 100 1point
            //Application displays the associated result based on the integer value range entered
            //Use if/else statements to make different actions depending on the user input
            //if the integer is odd, print the number entered and odd
            //if the integer entered is even and in the inclusive range 2 to 25 print "even and less than 25
            //if the integer entered is even and in the inclusive range of 26 to 60, print "even"
            //if the integer entereed is even and greatere than 60, print the number is "even"
            //if the integer is odd and greater than 60, print the entered and odd
            //remember to answer the LAB question Anthony
            //Bonus Points; Include a set of parameters so that the program ends offically
            //Ask for user name and use it in the outputs

            Console.WriteLine("Hello, what is your name?");
            string userName = (Console.ReadLine());

            while (true)
            {
               

                Console.WriteLine(userName + " please enter a number between 1 - 100");
                int userValue = int.Parse(Console.ReadLine());
                int leftOvers = userValue % 2;
                string choice;


                if (leftOvers == 1)
                {

                    Console.WriteLine(userName + " your number " + userValue + " and it is odd");
                }

                else if (userValue > 2 && userValue < 25 && leftOvers == 0)
                {
                    Console.WriteLine(userName + " your number is even and less than 25");
                }

                else if (userValue >= 25 && userValue < 60 && leftOvers == 0)
                {
                    Console.WriteLine(userName + " your number is even");
                }

                else if (userValue >= 60 && leftOvers == 0)
                {
                    Console.WriteLine(userName + " your number is even");
                }

                else if (userValue >= 60 && leftOvers == 1)
                {
                    Console.WriteLine(userName + " your number is " + userValue + " and it is odd");
                }

                

                Console.WriteLine("Would you like to input another number " + userName + "? Y or N");
                choice = Console.ReadLine().ToLower(); //for input validation
                

                if (choice == "n")
                {

                    Console.WriteLine("Goodbye " + userName +" thank you for playing!");
                    break;
                }
            }



        }
    }
}
