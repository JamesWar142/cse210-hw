using System;

class Program
{

    static void Main(string[] args)
    {
        int c = 0;
        Video genVideo = new Video();
        Comment genComment = new Comment();

        string video = genVideo.getVideo();
        Console.WriteLine($"{video}");
        while (true)
        {
            if (c != 3)
            {
                string comment = genComment.getComment();
                Console.WriteLine($"{comment}");
                c += 1;
            }
            else
            {
                break;
            }
        }
    }
}