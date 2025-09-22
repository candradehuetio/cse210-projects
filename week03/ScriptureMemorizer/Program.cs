using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        void Main()
        {
            // Hi teacher, the exceeding requirements to my project of this week were the function to read from a file of 
            // scriptures.txt, they where in a single line separated by "|", that way I was able to take out the reference and the single verse.
            // There are also some others like a message if the file is not found or does not exists, and it hides the words by randomly 
            // selecting one number, so that some times it will hide 1, 3, 5, 2 and so on... (8 maximum).


            // EXCEEDING REQUIREMENTS, READING SCRIPTURES.TXT

            // IF FILES DOES NOT EXIST
            string filepath = "scriptures.txt";
            if (!File.Exists(filepath))
            {
                Console.WriteLine("Could not find scriptures.txt");
                return;
            }

            string[] lines = File.ReadAllLines(filepath);
            List<Scripture> scriptures = new List<Scripture>();

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                Reference reference = new Reference(
                parts[0], //BOOK
                int.Parse(parts[1]), //CHAPTER
                int.Parse(parts[2]), // VERSE
                int.Parse(parts[3])); // END VERSE
                scriptures.Add(new Scripture(reference, parts[4]));

            }

            //RANDOM NUMBER WITHIN NUMBER ITEMS IN SCRPTURES LIST
            Random rand = new Random();
            Scripture verse = scriptures[rand.Next(scriptures.Count)];

            
            // MAIN LOOP
            while (true)
            {
                Console.Clear();

                Console.WriteLine(verse.GetDisplayText());
                Console.WriteLine();
                Console.Write("Press Enter to hide more words or type 'quit' to exit. ");

                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                if (verse.IsCompletelyHidden())
                {
                    break;
                }

                //SET THE NUMBER OF WORDS TO HIDE
                int numToHide = rand.Next(8);
                verse.HideRandomWords(numToHide);

            }

            Console.Clear();
            Console.WriteLine("All words hidden—or you chose to quit. Thanks for using the Scripture Memorizer!");
        }

        Main();
    }
}