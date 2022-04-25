using System.Collections.Generic;

namespace ShopYT.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public  string desk { get; set; }
       public List<Car> Cars { get; set; }

    }
}
