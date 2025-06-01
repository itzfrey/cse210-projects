using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Videos> videosList = new List<Videos>();

        // Video 1
        Videos video1 = new Videos("2024 Mercedes-AMG C63 S Review // We Drove it Over 1,000 MIles and Um, Yeah.", "Throttle House", 480);

        Comment video1Comment1 = new Comment("ericcarabetta1161", "It's impressive how much weight they can fit into such a small package.");
        Comment video1Comment2 = new Comment("Speaktruly", "Let's thank james and Thomas for bringing us a difficult and 100% honest revies");
        Comment video1Comment3 = new Comment("roquefernandess4126", "This show is getting very clos to the old Top Gear and i'm loving it. Keep up the good work guys");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Videos video2 = new Videos("How to make a website with login and register | HTML CSS & Javascript", "Codehal", 975);

        Comment video2Comment1 = new Comment("myhelshik5233", "Ayy! This looks very cool! if only i could access something like that in the previous year it could simplify me a lot of things. Thank you sir for the video.");
        Comment video2Comment2 = new Comment("relaxo2900", "Creating something from scratch is great, and this is what makes programmng more interesting that any field. ");
        Comment video2Comment3 = new Comment("plantn489", "it always amazes me how people like you make website programming look so easy");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Videos video3 = new Videos("Why I'm buying a Cybertruck!", "Carwow", 650);

        Comment video3Comment1 = new Comment("TheLeafyo", "Not having to worry about keeping the paing job pristine is surprisingly attractive quality.");
        Comment video3Comment2 = new Comment("bartwaggoner2000", "I can't get enough of people kicking the sh*t out of a vehicle and doing basically no damage");
        Comment video3Comment3 = new Comment("berthogendoorn2133", "Your Carwow reviews are so much more reliable as you all review anything that has wheels! keep it up!");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Videos video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}