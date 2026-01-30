using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                WriteEntry(journal, prompts);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
            }
        }
    }

    static void WriteEntry(Journal journal, PromptGenerator prompts)
    {
        string prompt = prompts.GetRandomPrompt();
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.Write("Response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry(date, prompt, response);
        journal.AddEntry(entry);

        Console.WriteLine("Entry saved.");
    }
}