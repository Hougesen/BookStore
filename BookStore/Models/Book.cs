namespace BookStore.Models
{
    public class Book : Publication
    {
        public string Author { get; set; }

        public long Isbn { get; set; }
    }
}
