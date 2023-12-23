using BookShop1Asm.Interfaces;
using AppDev.Models;
using AppDev.Data;

namespace BookShop1Asm.Repositories
{
    public class CategoryRepository : ICategory
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(Category category)
        {
            _context.Categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int? id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Category category)
        {
            _context.Categories.Add(category);
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}
