using System;

namespace BookStore.Models
{
    class Newspaper : Publication
    {
        public DateTime Date { get; set; }

        public int Pages { get; set; }
    }
}
