using ShopYT.Data.Models;
using System.Collections.Generic;

namespace ShopYT.Data.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> allCategoriies { get; }
    }
}
