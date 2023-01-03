using Biblio.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Biblio.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Bio")]        
        public string Bio { get; set; }

        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }

        //enum
        [Display(Name = "Genre")]
        public Genre genre { get; set; }

        //Relationships
        [Display(Name = "Books")]
        public List<Book> Books { get; set; }
    }
}
