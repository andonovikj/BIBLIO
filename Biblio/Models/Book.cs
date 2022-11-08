using Biblio.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblio.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public double Rating { get; set; }

        public string BookCoverURL { get; set; }

        //enum
        public Genre genre { get; set; }

        

        //FOREIGN KEY; 1-N RELATION (AUTHOR-BOOK)
        
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author author { get; set; }

        //public List<Review> reviews { get; set; }
    }
}
