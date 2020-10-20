using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                #region List<Car>
                return new List<Car>
                {
                    new Car{
                        name="Tesla Model S", 
                        shortDesc="Быстрый автомобиль", 
                        longDesc="Красивый, быстрый и очень тихий автомобиль компании Tesla", 
                        img="/img/Tesla Model S/tesla.jpg", 
                        price = 45000, 
                        isFavourite = true,
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car{
                        name="Ford Fiesta",
                        shortDesc="Тихий и спокойный",
                        longDesc="Очень удобный автомобиль для городской жизни",
                        img="/img/Ford Fiesta/ford.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car{
                        name="BMW M3",
                        shortDesc="Для крутыхх пацанов",
                        longDesc="Для дерзких любителей погонять по ночным улицам любимого города",
                        img="/img/BMW M3/bmw.jpg",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car{
                        name="Mercedes C class",
                        shortDesc="Уютный и большой",
                        longDesc="Для людей с зп под облока",
                        img="/img/Mercedes C class/mercedes.jpg",
                        price = 65000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car{
                        name="Nissan Leaf",
                        shortDesc="Бесшумный и экономный",
                        longDesc="Удобный автомобиль для учителей в школе",
                        img="/img/Nissan Leaf/nissan.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
                #endregion
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
