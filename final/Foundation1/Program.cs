using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<video> videos = new List<video>();

        video v1 = new video("5 ways to tie a tie", "Jacob Smith", 1.57);
        comment c1 = new comment("Sam Mills", "Now I don't have to have my wife tie my tie");
        v1.Addcomment(c1);

        video v2 = new video("Chevy vs. Ford ")

    }
}