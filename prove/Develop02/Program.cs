using System;



namespace ConsoleApplication1
{
    class Program
    {
        static Journal journal = new Journal();
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                option = presentOptions();
                switch(option)
                {
                    case 1:
                        onWriteOptionSelected();
                        break;
                    case 2:
                        onDisplayOptionSelected();
                        break;
                    case 3:
                        onLoadOptionSelected();
                        break;
                    case 4:
                        onSaveOptionSelected();
                        break;
                }

            } while (option != 5);
            
        }
        static void printOptions()
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
        }
        static int presentOptions()
        {
            int option = -1;
            do
            {
                printOptions();
                Console.Write("What would you like to do? ");
                string input = Console.ReadLine();
                Int32.TryParse(input, out option);
                if (option <= 0 || option > 5)
                {
                    Console.WriteLine("Answer must be a number from 1 to 5.");
                }
            } while (option <= 0 || option > 5);
            return option;
        }
        static void onWriteOptionSelected()
        {
            string prompt = Prompts.GetRandomPrompt();
            DateTime time = DateTime.Now;
            Console.WriteLine(prompt);
            Console.Write(" > ");
            string answer = Console.ReadLine();
            Entry entry = new Entry(prompt, answer, time);
            journal.AddEntry(entry);
        }
        static void onDisplayOptionSelected()
        {
            Console.WriteLine(journal);
        }
        static void onLoadOptionSelected()
        {
            Console.Write("What is the filename? ");
            string filename = Console.ReadLine();
            journal.LoadEntriesFromFile(filename);
        }
        static void onSaveOptionSelected()
        {
            Console.Write("What is the filename? ");
            string filename = Console.ReadLine();
            journal.SaveEntriesToFile(filename);
        }

    }
}
