using Microsoft.EntityFrameworkCore;
using ShopYT.Data.interfaces;
using ShopYT.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopYT.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Car> Cars => appDBContent.Car.Include(c=>c.Category);

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p=>p.isFavourite).Include(c=>c.Category);

        public Car getObjectInteger(int carId) => appDBContent.Car.FirstOrDefault(p=>p.id==carId);
        
    }
}
