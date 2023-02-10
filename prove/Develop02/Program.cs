using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Generator generator = new Generator();


        Console.WriteLine("Welcome to the journal program");

        string userInput = "";
        while (userInput != "5")
        {
            DisplayMenu();
            Console.WriteLine("Please select one of the following choices: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                //Write in the journal
                Console.WriteLine("Writing an entry.");
                //Get and display propmt
                string prompt = generator.RandPrompt();
                Console.WriteLine(prompt);
                //Get Response
                Console.Write("--"); 
                string response = Console.ReadLine();
                //Get the current date
                DateTime localDate = DateTime.Now;
                string date =localDate.ToString("dd/MM/yyyy");
                //Create entry object
                Entry entry = new Entry();
                entry._date = date;
                entry._prompt = prompt;
                entry._text = response;
                //Add it to the journal
                myJournal._entries.Add(entry);
            }
            else if (userInput == "2")
            {
                //Diplay the journal entries
                myJournal.Display();
            }
            else if (userInput == "3")
            {
                //Save the journal
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                myJournal.Save(file);
            }
            else if (userInput == "4")
            {
                //Load the journal and all the entries
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                myJournal.Load(file);
        
            }
            else if (userInput == "5")
            {
                //Quitting the program
                Console.WriteLine("Thank You");
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What one would you like to do? ");
        }
    }
}
       
