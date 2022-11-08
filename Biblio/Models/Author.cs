using Biblio.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Biblio.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string ProfilePictureURL { get; set; }

        //enum
        public Genre genre { get; set; }

        //Relationships
        public List<Book> Books { get; set; }
    }
}
