using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathing = new Breathing();
        Reflecting reflecting = new Reflecting();
        Listing listing = new Listing();

        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("Welcome to the mindfulness program");
        Console.WriteLine();

        string userInput = "";
        while (userInput != "4"){
            DisplayMenu();
            Console.WriteLine("Please choose one of the following: ");
            userInput = Console.ReadLine();
            Console.WriteLine();

            //Starting the breathing activity//
            if (userInput == "1"){
                breathing.doActivity();
            }
            //Starting the reflecting activity//
            else if (userInput == "2"){
                reflecting.doActivity();
            }
            //Starting the listing activity//
            else if (userInput == "3"){
                listing.doActivity();
            }
            //Quitting the program//
            else if (userInput == "4"){
                Console.WriteLine("Thank You!");
                break;
            }
            else{
                Console.WriteLine("Invalid Input");
            }
        }


        static void DisplayMenu()
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit the program");
            Console.WriteLine();
        }
    }
}