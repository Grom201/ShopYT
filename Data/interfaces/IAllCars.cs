using ShopYT.Data.Models;
using System.Collections.Generic;

namespace ShopYT.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;}
        IEnumerable<Car> getFavCars { get; }
        Car getObjectInteger(int carId);
    }
}
