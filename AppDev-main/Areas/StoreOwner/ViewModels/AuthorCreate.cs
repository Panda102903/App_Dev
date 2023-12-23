using AppDev.Models;
using System.Collections.Generic;
namespace AppDev.Areas.StoreOwner.ViewModels
{
    public class AuthorCreate
    {
        public string Name { get; set; } = null!;
        public List<Author> Authors { get; set; }
        public string SearchString { get; set; }
    }
}

