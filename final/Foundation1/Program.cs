using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>();

        Video v1 = new Video("5 ways to tie a tie", "Jacob Smith", 5);
        Video v2 = new Video("Chevy vs. Ford", "trucklover99", 2);
        Video v3 = new Video("Best street tacos in 3 minutes", "Don Inigo", 3);

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        v1.Addcomment("Sam Mills", "Now I don't have to have my wife tie my tie");
        v1.Addcomment("Rosa Peters", "Thank you so much, I make my husband tie his own tie now.");
        v1.Addcomment("Joe Mattson", "I love the color of your tie, great video!");

        v2.Addcomment("Jack Jones", "Brooo there is no comparing, Chevy is the way to go!");
        v2.Addcomment("Jill Jensen", "What size of tires did oyu have on that Ford?");
        v2.Addcomment("Bill Waters", "Get those weak sauce toys outta here, Dodge is a real mans truck!!!");

        v3.Addcomment("Jose Perez", "Come try my famous taquitos, you won't be sorry.");
        v3.Addcomment("Julio Alvarez", "Homie don't lie! His tacos are legit, I go make his recipe every Thursday after work!");
        v3.Addcomment("Daniel Rica", "Don is the man, he will leave you wanting more, trust me!!!");


        foreach(Video video in videos){
            video.DisplayVideo();
        }

    }
        
}