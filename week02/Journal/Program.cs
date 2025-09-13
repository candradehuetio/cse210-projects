using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        /* Hi teacher the exceeding reqiremets were the option to save the journey in a csv file separated by the "$$" caracters. I did this in order to not get errors  when 
        the user types a comma, so that the reader can read it and display the message correctly. Also I added some additional messages when the user reads and load the file*/
        void main()
        {
            /// instance from the PromptGenerator class
            PromptGenerator generate = new PromptGenerator();

            /// instance from Journal class to add the entry
            Journal JournalBook = new Journal();

            /// date time module object created
            DateTime theCurrentTime = DateTime.Now;


            string response = "0";
            while (response != "5")
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to the Journal Program");
                Console.WriteLine("Please select one of the following");
                Console.WriteLine("1.Write");
                Console.WriteLine("2.Display");
                Console.WriteLine("3.Load");
                Console.WriteLine("4.Save");
                Console.WriteLine("5.Quit");
                Console.Write("What would you like to do? ");
                response = Console.ReadLine();

                if (response == "1")
                {
                    /// getting and displaying the prompt to the user
                    string prompt = generate.GetRandomPrompt();
                    Console.WriteLine(prompt);


                    // instance from the entry class to store the data in the list
                    Entry entry = new Entry();

                    //////// storing the entry, the prompt and the date to the member variables from entries
                    entry._date = theCurrentTime.ToShortDateString();/// Date object to string
                    entry._promptText = prompt;
                    entry._entryText = Console.ReadLine();

                    // Adding the entry to the list by using the AddEntry method.
                    JournalBook.AddEntry(entry);
                }

                else if (response == "2")
                {
                    JournalBook.DisplayAll();
                }


                else if (response == "3")
                {
                    Console.Write("Enter the name of the file: ");
                    string file = Console.ReadLine();
                    Console.WriteLine("Reading the file...");
                    JournalBook.LoadFromFile(file);

                }

                else if (response == "4")
                {
                    Console.Write("Enter the name of the file: ");
                    string file = Console.ReadLine();
                    Console.WriteLine("Saviing the file...");

                    /// Saving the file afer providing the filename
                    JournalBook.SaveToFile(file);

                }
                
            }
        }


        main();
    }
}