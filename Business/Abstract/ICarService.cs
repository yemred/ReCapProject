using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsBrandId(int id);  
        IDataResult<List<Car>> GetCarsColorsId();
        IResult Add(Car car);
        IResult Update(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails(int id);
        IResult AddTransactionalTest(Car car);

    }
}
