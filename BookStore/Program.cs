using System;
using BookStore.Controllers;

namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();



            string[] publicationTypes = new string[] { "book", "newspaper" };


            string[] options = new string[] {
                "s - Search publications",
                "l - List inventory",
            };



            bool validOption = false;
            string selectedOption;


            do
            {
                Console.WriteLine("What are you interested in doing?");
                foreach (string option in options)
                {
                    Console.WriteLine(option);
                }

                selectedOption = Console.ReadLine().Trim().ToLower();

                if (selectedOption == "s" || selectedOption == "l")
                {
                    validOption = true;
                }

            }
            while (validOption == false);



            if (selectedOption == "s")
            {
                Console.WriteLine("Write title of publication you want to search for");
                string title = Console.ReadLine();


                Console.WriteLine("What kind of publication? \n book \n newspaper \n press enter for everything");

                string publicationType = Console.ReadLine().Trim().ToLower();

                inventory.Search(title, publicationType);
            }
            else if (selectedOption == "l")
            {
                Console.WriteLine("What kind of publication? \n books \n newspapers \n press enter for everything");

                string publicationType = Console.ReadLine().Trim().ToLower();

                inventory.ListInventory(publicationType);
            }

        }
    }
}
