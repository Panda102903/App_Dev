using BookShop1Asm.Interfaces;
using AppDev.Models;
using AppDev.Data;
using Microsoft.EntityFrameworkCore;

namespace BookShop1Asm.Repositories
{
    public class BookRepository : IBook
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(Book book)
        {
            _context.Books.Remove(book);
        }

        public List<Book> GetAll()
        {
            return _context.Books.Include("BookCategories.Category").ToList();
        }

        public List<Book> Search(string str)
        {
            return _context.Books.Include("BookCategories.Category").Where(s => s.Title!.Contains(str)).ToList();
        }

        public Book GetById(int? id)
        {
            return _context.Books.Include("BookCategories.Category").Include("BookAuthors.Author").FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Book book)
        {
           _context.Books.Add(book);
        }

        public void Update(Book book)
        {
            _context.Books.Update(book);
        }
    }
}
