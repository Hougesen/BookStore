using System;
using BookStore.Controllers;

namespace BookStore
{
    class Program
    {

        public static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            // Simple cli program that automatically start again when action is done
            bool exitedProgram = false;
            while (!exitedProgram)
            {
                string[] options = new string[] { "s - Search publications", "l - List inventory", "a - Add publication", };
                bool validOption = false;
                string selectedOption;

                // Select what to do
                do
                {
                    Console.WriteLine("What are you interested in doing?");
                    foreach (string option in options)
                    {
                        Console.WriteLine(option);
                    }

                    selectedOption = Console.ReadLine().Trim().ToLower();

                    if (selectedOption == "s" || selectedOption == "l" || selectedOption == "a")
                    {
                        validOption = true;
                    }

                }
                while (validOption == false);

                if (selectedOption == "s")
                {
                    // Search for publication

                    ConsoleWrapper("Write is the title of the publication you want to search for");
                    string title = Console.ReadLine();

                    ConsoleWrapper("What kind of publication do you wish to search? \n book \n newspaper \n press enter for everything");
                    string publicationType = Console.ReadLine().Trim().ToLower();

                    inventory.Search(title, publicationType);

                }
                else if (selectedOption == "l")
                {
                    // List inventory
                    ConsoleWrapper("What kind of publication? \n books \n newspapers \n press enter for everything");
                    string publicationType = Console.ReadLine().Trim().ToLower();

                    inventory.ListInventory(publicationType);
                }
                else if (selectedOption == "a")
                {
                    // Add new publication

                    bool validType = false;
                    string newPubType = "";
                    while (!validType)
                    {
                        ConsoleWrapper("What kind of publication? \n book \n newspaper");

                        newPubType = Console.ReadLine().Trim().ToLower();

                        if (newPubType == "book" || newPubType == "newspaper")
                        {
                            validType = true;
                        }
                    }

                    ConsoleWrapper($"What is the title of the {newPubType}?");
                    string title = Console.ReadLine().Trim();

                    ConsoleWrapper($"Who is the publisher of {title}?");
                    string publisher = Console.ReadLine().Trim();

                    ConsoleWrapper($"What is the price of {title}?");
                    decimal price = 0;
                    bool validPrice = false;

                    while (!validPrice)
                    {

                        try
                        {
                            string input = Console.ReadLine();

                            price = Convert.ToDecimal(input);

                            validPrice = true;
                        }
                        catch (FormatException error)
                        {
                            Console.WriteLine("Please input a valid number", error);
                        }

                    }

                    if (newPubType == "book")
                    {
                        ConsoleWrapper($"Who is the author of {title}?");
                        string author = Console.ReadLine().Trim();

                        ConsoleWrapper($"What is the ISBN of {title}?");
                        bool validIsbn = false;
                        int isbn = 0;

                        while (!validIsbn)
                        {
                            try
                            {
                                string input = Console.ReadLine();
                                isbn = Int32.Parse(input);
                                validIsbn = true;
                            }
                            catch (FormatException error)
                            {
                                Console.WriteLine("Please input a valid number", error);
                            }
                        }

                        inventory.AddBook(title, author, publisher, price, isbn);
                    }
                    else if (newPubType == "newspaper")
                    {
                        ConsoleWrapper($"How many pages are {title}?");

                        bool validPageAmount = false;
                        int pageAmount = 0;

                        while (!validPageAmount)
                        {

                            try
                            {
                                string input = Console.ReadLine();

                                pageAmount = Int32.Parse(input);

                                validPageAmount = true;
                            }
                            catch (FormatException error)
                            {
                                Console.WriteLine("Please input a valid number", error);
                            }
                        }

                        inventory.AddNewspaper(title, publisher, price, pageAmount);
                    }

                    ConsoleWrapper($"Finished adding new {newPubType} \n");
                }
            }
        }

        public static void ConsoleWrapper(string text)
        {
            Console.Clear();
            Console.WriteLine(text);
        }
    }
}
