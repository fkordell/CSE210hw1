using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        //Create New Scripture
        Scripture scripture = new Scripture("Mosiah 2:22" , "And behold, all that he arequires of you is to keep his commandments; and he has promised you that if ye would keep his commandments ye should prosper in the land; and he never doth vary from that which he hath said; therefore, if ye do keep his commandments he doth bless you and prosper you.");
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