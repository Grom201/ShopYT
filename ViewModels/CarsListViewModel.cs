using ShopYT.Data.Models;
using System.Collections.Generic;

namespace ShopYT.ViewModels
{
    public class CarsListViewModel
    {
      public  IEnumerable<Car> allCars { get; set; }
        
        public string currCategory { get; set; }
    }
}
