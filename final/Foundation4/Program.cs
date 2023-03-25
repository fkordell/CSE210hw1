using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running();
        Cycling cycling = new Cycling();
        Swimming swimming = new Swimming();

        Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine();
        Console.WriteLine("Welcome to the Exercise Tracking program!");
        Console.WriteLine();

        string userInput = "";
        while(userInput != "4"){
            DisplayMenu();
            Console.WriteLine("Which exercise activity would you like to track?");
            userInput = Console.ReadLine();
            Console.WriteLine();

            if (userInput == "1"){
                running.doActivity();
            }
            else if(userInput == "2"){
                cycling.doActivity();
            }
            else if(userInput == "3"){
                swimming.doActivity();
            }
            else if(userInput == "4"){
                Console.WriteLine("Thank You!");
                break;
            }
            else{
                Console.WriteLine("Invalid input, please try again");
            }

        }

        static void DisplayMenu(){
            Console.WriteLine("1. Track my running");
            Console.WriteLine("2. Track my cycling");
            Console.WriteLine("3. Track my swimming");
            Console.WriteLine("4. Quit the app");
            Console.WriteLine();
        }
      
    }
}