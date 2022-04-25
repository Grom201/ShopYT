using ShopYT.Data.interfaces;
using ShopYT.Data.Models;
using System.Collections.Generic;

namespace ShopYT.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {

        private readonly AppDBContent appDBContent;

        public CategoryRepository (AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> allCategoriies => appDBContent.Category;
    }
}
