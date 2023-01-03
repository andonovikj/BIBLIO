using Biblio.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblio.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string? Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Rating")]
        public double Rating { get; set; }

        [Display(Name = "Book Cover URL")]
        public string BookCoverURL { get; set; }

        //enum
        [Display(Name = "Genre")]
        public Genre genre { get; set; }

        

        //FOREIGN KEY; 1-N RELATION (AUTHOR-BOOK)
        
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]

        [Display(Name = "Author")]
        public Author author { get; set; }

        //public List<Review> reviews { get; set; }
    }
}
