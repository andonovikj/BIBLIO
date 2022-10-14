namespace Biblio.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public string Description { get; set; }

        public double Rating { get; set; }

        //enum
        public Genre genre { get; set; }

        public Author author { get; set; }

        public List<Review> reviews { get; set; }
    }
}
