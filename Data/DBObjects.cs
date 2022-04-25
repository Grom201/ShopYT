using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ShopYT.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopYT.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if(!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c=>c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(

                    new Car
                    {
                        name = "toyota",
                        shortDesk = "",
                        longDesk = "",
                        img = "/img/toyota.jpg",
                        availebale = true,
                        price = 45000,
                        isFavourite = true,
                        Category = Categories["ClassicAutomobile"]
                    },
                     new Car
                     {
                         name = "nissan leaf",
                         shortDesk = "",
                         longDesk = "",
                         img = "/img/leaf.jpg",
                         availebale = true,
                         price = 40000,
                         isFavourite = false,
                         Category =Categories["Electromobile"]
                     }

                    ) ;
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get{
                if (category==null)
                {
                    var list = new Category[]
                    {
                         new Category { categoryName = "Electromobile", desk = "automobile with electro engine" },
                         new Category { categoryName = "ClassicAutomobile", desk = "automobile with classic another engine" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName,el);
                }
                return category;
            }

        }
    }
}
