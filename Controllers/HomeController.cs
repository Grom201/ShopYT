using Microsoft.AspNetCore.Mvc;
using ShopYT.Data.interfaces;
using ShopYT.ViewModels;

namespace ShopYT.Controllers
{
    public class HomeController:Controller
    {

        private readonly IAllCars _carRep;
       

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
            
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRep.getFavCars
            };

            return View(homeCars);
        }
    }
}
