using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        //Create New Scripture
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        //Clear the Console
        Console.Clear();
        scripture.DisplayScripture();

        //Prompt the user to press enter or  type quit
        while (true){
            Console.WriteLine("Press enter to hide a word or type quit to end the program");
            string userInput = Console.ReadLine();

            //If the user types quit, then end the program
            if (userInput.ToLower() == "quit"){
                break;
            }
            else{
                //Clear the console and hide random words
                Console.Clear();
                scripture.HideWord();
                scripture.DisplayScripture();

                //Check to see if all the words have been hidden
                if (scripture.AllWordsHidden()){
                    Console.WriteLine("Congratuations you have completely memorized this scripture.");
                    break;
                }
            }
        }
    }
}