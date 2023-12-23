using System.ComponentModel.DataAnnotations;

namespace AppDev.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }

}
