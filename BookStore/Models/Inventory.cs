using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public class Inventory
    {
        private List<Newspaper> Newspapers = new List<Newspaper>();

        private List<Book> Books = new List<Book>();

        public Inventory()
        {
            Book book1 = new Book
            {
                Id = 1,
                Title = "Natrium Chlorid test",
                Author = "Jussi Adler-Olsen",
                Publisher = "Politikens Forlag",
                Price = 199.95m,
                Isbn = 9788740045130
            };

            Book book2 = new Book
            {
                Id = 2,
                Title = "Flaskepost fra P",
                Author = "Jussi Adler-Olsen",
                Publisher = "Politikens Forlag",
                Price = 129.95m,
                Isbn = 9788740056402
            };


            Newspaper newspaper1 = new Newspaper
            {
                Id = 1,
                Title = "The Washington Post test",
                Date = DateTime.Now,
                Publisher = "Fred Ryan",
                Price = 123.34m,
                Pages = 40,
            };

            Newspaper newspaper2 = new Newspaper
            {
                Id = 2,
                Title = "The New York Times",
                Date = DateTime.Now,
                Publisher = "A.G. Sulzberger",
                Price = 123.34m,
                Pages = 40,
            };

            Books.Add(book1);
            Books.Add(book2);

            Newspapers.Add(newspaper1);
            Newspapers.Add(newspaper2);
        }

        public void ListInventory(string type = null)
        {
            if (type == "books")
            {
                ListBookInventory();
            }
            else if (type == "newspaper")
            {
                ListBookInventory();
            }
            else
            {
                ListBookInventory();
                ListNewspaperInventory();
            }

        }

        public void ListBookInventory()
        {
            Console.WriteLine("The following books are in stock:");

            foreach (Book book in Books)
            {
                Console.WriteLine($"{book.Title} by {book.Author} - ISBN: {book.Isbn}");
            }
        }

        public void ListNewspaperInventory()
        {
            Console.WriteLine("The following newspapers are in stock: ");

            foreach (Newspaper newspaper in Newspapers)
            {
                Console.WriteLine($"{newspaper.Title} - {newspaper.Date}");
            }
        }


    }
}
