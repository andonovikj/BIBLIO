namespace Biblio.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string ProfilePictureURL { get; set; }

        //enum
        public Genre genre { get; set; }

        public List<Book> books { get; set; }
    }
}
