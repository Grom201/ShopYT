using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopYT.Data;
using ShopYT.Data.interfaces;
using ShopYT.Data.Models;
using ShopYT.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYT.Controllers
{
    public class CarController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        private AppDBContent db;

        public object AppDbContent { get; private set; }

        public CarController(IAllCars iAllCars, ICarsCategory iCarsCat, AppDBContent content)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
            db = content;
        }

        [Route("Car/List")]
        [Route("Car/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCat = "";

            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("electro", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Electromobile")).OrderBy(i => i.id);
                    currCat = "Electromobile";
                }
                else if (string.Equals("fuel", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("ClassicAutomobile")).OrderBy(i => i.id);
                    currCat = "ClassicAutomobile";
                }
            }

            var carobj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCat
            };

            return View(carobj);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Car cars = await db.Car.FirstOrDefaultAsync(p => p.id == id);

                if (cars != null)
                    return View(cars);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Car cars)
        {

            db.Car.Update(cars);
            await db.SaveChangesAsync();
            return RedirectToAction("List");
        }

        [HttpPost]
        public async Task<IActionResult>AddNewCar(Car car)
        {
            var newCar =
                new Car
                {
                    name = car.name,
                    shortDesk = car.shortDesk,
                    longDesk = "",
                    img = "/img/toyota.jpg",
                    availebale = true,
                    price = 45000,
                    isFavourite = true,
                    Category = car.Category
                };
            db.Car.AddAsync(newCar);
            await db.SaveChangesAsync();
            return RedirectToAction("List");
        }

    }
}
