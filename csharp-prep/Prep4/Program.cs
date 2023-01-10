using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

         List<int> numbers = new List<int>();
    int num = -1;
    while (num != 0)
    {
        Console.Write("Enter some numbers, type 0 when finished. ");

        string inputnum = Console.ReadLine();
        num = int.Parse(inputnum);

        if (num != 0)
        {
            numbers.Add(num);
        }
    }
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    Console.WriteLine($"The sum is {sum}");

    float avg = ((float)sum) / numbers.Count;
    Console.WriteLine($"The average is {avg}");

    int max = numbers[0];

    foreach (int number in numbers)
    {
        if (number > max)
        {
            max = number;
        }
    }

        Console.WriteLine($"The max number is {max}");

    }


   
}