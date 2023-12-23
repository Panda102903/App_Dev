using BookShop1Asm.Interfaces;
using AppDev.Models;
using AppDev.Data;

namespace BookShop1Asm.Repositories
{
    public class AuthorRepository : IAuthor
    {
        private readonly ApplicationDbContext _context;
        public AuthorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(Author author)
        {
            _context.Authors.Remove(author);
        }

        public List<Author> GetAll()
        {
            return _context.Authors.ToList();
        }

        public Author GetById(int? id)
        {
            return _context.Authors.FirstOrDefault(x => x.AuthorId == id);
        }

        public void Insert(Author author)
        {
            _context.Authors.Add(author);
        }

        public void Update(Author author)
        {
            throw new NotImplementedException();
        }
    }
}