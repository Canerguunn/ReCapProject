using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            BrandTest();
            //ColorTest();
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                System.Console.WriteLine(car.ColorName+" "+car.CarName + " / " + car.BrandName);
            }
        }

        static void BrandTest() {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll())
            {
                System.Console.WriteLine(brand.Id);
            }


        }
        static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                System.Console.WriteLine(color.Name);
            }
        }
    }
}
