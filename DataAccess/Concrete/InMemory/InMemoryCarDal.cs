using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal      
    {
        List<Car> _cars;

        public InMemoryCarDal() {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=2,DailyPrice=150,ModelYear="11-2-2020",Descpription="2020 Model Renault" },
                new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=450,ModelYear="7-1-2010",Descpription="2010 Model Peugeot" },
                new Car{Id=3,BrandId=3,ColorId=3,DailyPrice=350,ModelYear="19-6-2009",Descpription="2009 Model Fiat" }
            };
        
        }
        
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            Car selectedCar = _cars.SingleOrDefault(c => c.Id == id);
            return selectedCar;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descpription = car.Descpription;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
