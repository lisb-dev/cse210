using System;

class Program
{
    static void Main(string[] args)
    {
        // Store the scripture reference and text
        Scripture scripture = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths.");

        // Main loop for hiding words and user input
        while (true)
        {
            scripture.Display();
            
            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3); // Hides 3 random words at a time
        }
    }
}
