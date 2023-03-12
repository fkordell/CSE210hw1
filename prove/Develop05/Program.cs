using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goals> _recordedGoals = new List<Goals>();

        Console.WriteLine();
        Console.WriteLine("Hello Develop05 World!");
        Console.WriteLine("Welcome to the Eternal Quest program");
        Console.WriteLine();

        string userInput = "";
        string userInput1 = "";
        while (userInput != "6"){
            Console.WriteLine("Menu Options: ");
            DisplayMenu();
            Console.WriteLine("Please choose one of the following: ");
            Console.WriteLine();
            userInput = Console.ReadLine();
            Console.WriteLine();

            if(userInput == "1"){
                Console.WriteLine("The types of goals are: ");
                DisplayMenu1();
                Console.WriteLine("Which type of goal would you like to create? ");
                Console.WriteLine();
                userInput1 = Console.ReadLine();
                Console.WriteLine();
                if(userInput1 == "1"){
                    Simple simple = new Simple();
                    simple.GetInput();
                    _recordedGoals.Add(simple);
                }
                else if(userInput1 == "2"){
                    Eternal eternal = new Eternal();
                    eternal.GetInput();
                    _recordedGoals.Add(eternal);
                }
                else if(userInput1 == "3"){
                    Checklist checklist = new Checklist();
                    checklist.GetInput();
                    _recordedGoals.Add(checklist);
                };
                

            }
            else if(userInput == "2"){
                Console.WriteLine($"You have {_recordedGoals.Count} goals in your to-do list currently.");
                Console.WriteLine("The goals are:");
                Console.WriteLine();
            foreach(Goals goal in _recordedGoals){
                Console.WriteLine($"[ ] {goal.displayGoals()}");
                Console.WriteLine();
            }

            }
            else if(userInput == "3"){
                Console.WriteLine("What is the name of the file? ");
                string file = Console.ReadLine();
                string s = "";
                foreach(Goals goal in _recordedGoals){
                    s += goal.toFileLine() + "\n";
                }
                using (StreamWriter outputFile = new StreamWriter(file)){
                        outputFile.WriteLine(s);
                }

            }
            else if(userInput == "4"){
                Console.WriteLine("What is the name of the file? ");
                string file = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(file);
                foreach(string line in lines){
                    if(line == ""){
                        continue;
                    }
                    string type = line.Substring(0,1);
                    if(type == "E"){
                        Eternal eternal = new Eternal();
                        eternal.fromFileLine(line);
                        _recordedGoals.Add(eternal);
                    }
                    else if(type == "S"){
                        Simple simple = new Simple();
                        simple.fromFileLine(line);
                        _recordedGoals.Add(simple);
                    }
                    else if (type == "C"){
                        Checklist checklist = new Checklist();
                        checklist.fromFileLine(line);
                        _recordedGoals.Add(checklist);
                    }

                }
            }
            else if(userInput == "5"){
                Console.WriteLine("What goal did you do? ");
            

            }
            else if(userInput == "6"){
                Console.WriteLine("Thank You!");
                break;
            }
            else{
                Console.WriteLine("Invalid input, please try again.");
            }
        }

        static void DisplayMenu(){
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
        }

        static void DisplayMenu1(){
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
        }
    }
}