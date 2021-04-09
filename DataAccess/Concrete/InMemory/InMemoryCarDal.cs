using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id=1, BrandId=1, ColorId=1, ModelYear=new DateTime(1991), DailyPrice=22000,Description="OPEL" },
                new Car{ Id=2, BrandId=2, ColorId=2, ModelYear=new DateTime(1992), DailyPrice=22000,Description="MERCEDES" },
                new Car{ Id=3, BrandId=3, ColorId=2, ModelYear=new DateTime(1993), DailyPrice=22000,Description="BMW" },
                new Car{ Id=4, BrandId=4, ColorId=3, ModelYear=new DateTime(1994), DailyPrice=22000,Description="Audi" },
                new Car{ Id=5, BrandId=5, ColorId=3, ModelYear=new DateTime(1990), DailyPrice=22000,Description="Ford" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GeTById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
