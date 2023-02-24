using System;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Hello Develop04 World!");
        Console.Writeline("Welcome to the minfulness program");

        string userInput = "";
        while (userInput != "4"){
            DisplayMenu();
            Console.Writeline("Please choose one of the following: ");
            userInput = Console.ReadLine();

            //Starting the breathing activity//
            if (userInput == "1"){

            }
            //Starting the reflecting activity//
            else if (userInput == "2"){

            }
            //Starting the listing activity//
            else if (userInput == "3"){

            }
            //Quitting the program//
            else if (userInput == "4"){
                Console.WriteLine("Thank You!")
                break
            }
            else{
                Console.WriteLine("Invalid Input")
            }
        }


        static void DisplayMenu()
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.Writeline("4. Quit the program");
            Console.Write("What one would you like to do? ");
        }
    }
}