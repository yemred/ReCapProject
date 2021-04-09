using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
          
            _carDal.Add(car);
            return new SuccessResult();
        }

        public IDataResult<List<Car>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsColorsId()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
