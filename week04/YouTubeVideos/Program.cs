using System;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        void Main()
        {
            //  VIDEO 1 WITH ITS 3 COMMENTS
            Video video1 = new Video();

            video1._authorVideo = "Carlos Andrade";
            video1._titleVideo = "How to bake bread";
            video1._lengthVideo = 300;

            Comment comment1 = new Comment();
            comment1._commentName = "Sofia";
            comment1._commentText = "That is such a good recipe! I will try it out at home.";
            video1._comments.Add(comment1);

            Comment comment2 = new Comment();
            comment2._commentName = "Jean";
            comment2._commentText = "I think you used too salt on the recipe! but everything else is fine though.";
            video1._comments.Add(comment2);

            Comment comment3 = new Comment();
            comment3._commentName = "Jackeline";
            comment3._commentText = "It would have been great if you added raisins!";
            video1._comments.Add(comment3);
            // NUMBER OF COMMMENTS
            int numComments = video1.GetNumberComments();


            // DISPLAYING
            Console.WriteLine("TITLE OF THE VIDEO: " + video1._titleVideo);
            Console.WriteLine("AUTHOR OF THE VIDEO: " + video1._authorVideo);
            Console.WriteLine("LENGTH OF THE VIDEO: " + video1._lengthVideo + " SECONDS");
            Console.WriteLine($"------------- COMMENTS [{numComments}]----------------");
            // lOOP TO ITERATE THROUGH THE COMMENT LIST OBJECTS
            foreach (Comment comment in video1._comments)
            {
                string name = comment._commentName;
                string text = comment._commentText;

                Console.WriteLine(name);
                Console.WriteLine("     " + text);
            }

            // VIDEO 2 WITH ITS 3 COMMENTS;
            Video video2 = new Video();
            video2._authorVideo = "Stephanie";
            video2._titleVideo = "How to drive a car";
            video2._lengthVideo = 600;

            comment1._commentName = "Carla";
            comment1._commentText = "You drive really well!";
            video2._comments.Add(comment1);

            comment2._commentName = "Joseph";
            comment2._commentText = "What was that thind saw in the 3:33 minute?";
            video2._comments.Add(comment2);

            comment3._commentName = "Jackeline";
            comment3._commentText = "My son is taking his driving license course, this will help him.";
            video2._comments.Add(comment3);
            // NUMBER OF COMMMENTS
            numComments = video2.GetNumberComments();

            Console.WriteLine();
            Console.WriteLine();
            // DISPLAYING
            Console.WriteLine("TITLE OF THE VIDEO: " + video2._titleVideo);
            Console.WriteLine("AUTHOR OF THE VIDEO: " + video2._authorVideo);
            Console.WriteLine("LENGTH OF THE VIDEO: " + video2._lengthVideo + " SECONDS");
            Console.WriteLine($"------------- COMMENTS [{numComments}]----------------");
            // lOOP TO ITERATE THROUGH THE COMMENT LIST OBJECTS
            foreach (Comment comment in video2._comments)
            {
                string name = comment._commentName;
                string text = comment._commentText;

                Console.WriteLine(name);
                Console.WriteLine("     " + text);
            }

            // VIDEO 3 WITH ITS 3 COMMENTS
            Video video3 = new Video();

            video3._authorVideo = "Mary";
            video3._titleVideo = "How to hear the voice of the Lord.";
            video3._lengthVideo = 650;

            comment1._commentName = "Carla";
            comment1._commentText = "I do not believe I was misunderstanding this.";
            video3._comments.Add(comment1);

            comment2._commentName = "Carlos";
            comment2._commentText = "I always knew that having a journey would help!";
            video3._comments.Add(comment2);

            comment3._commentName = "Karen";
            comment3._commentText = "I always confuse evil's voice with Lord's voice.";
            video3._comments.Add(comment3);
            // NUMBER OF COMMMENTS
            numComments = video3.GetNumberComments();

            Console.WriteLine();
            Console.WriteLine();
            // DISPLAYING
            Console.WriteLine("TITLE OF THE VIDEO: " + video3._titleVideo);
            Console.WriteLine("AUTHOR OF THE VIDEO: " + video3._authorVideo);
            Console.WriteLine("LENGTH OF THE VIDEO: " + video3._lengthVideo + " SECONDS");
            Console.WriteLine($"------------- COMMENTS [{numComments}]----------------");
            // lOOP TO ITERATE THROUGH THE COMMENT LIST OBJECTS
            foreach (Comment comment in video3._comments)
            {
                string name = comment._commentName;
                string text = comment._commentText;

                Console.WriteLine(name);
                Console.WriteLine("     " + text);
            }

        }

        Main();
    
    }
}