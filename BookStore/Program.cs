using System; 
using BookStore.Controllers;

namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            // inventory.ListInventory(); // List all publications
            // inventory.ListInventory("books"); // List all books
            // inventory.ListInventory("newspapers"); // List all newspapers

            // inventory.Search("test"); // Search all publications
            // inventory.Search("Natrium", "book"); // Search books
            // inventory.Search("Times", "newspaper"); // Search newspapers
        }
    }
}
