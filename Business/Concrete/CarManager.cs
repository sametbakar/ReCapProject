using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
                _carDal.Add(car);
                return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetById(int carId)
        {
            var result = new List<CarDetailDto>();
            var cars = _carDal.GetCarDetails().ToList();
            foreach (var car in cars)
            {
                if (car.CarId == carId)
                {
                    result.Add(car);
                }
            }
            return new SuccessDataResult<List<CarDetailDto>>(result.ToList());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandId(int brandId)
        {
            var result = new List<CarDetailDto>();
            var cars = _carDal.GetCarDetails().ToList();
            foreach (var car in cars)
            {
                if (car.BrandId == brandId)
                {
                    result.Add(car);
                }
            }
            return new SuccessDataResult<List<CarDetailDto>>(result.ToList());
        }

        public IDataResult<List<CarDetailDto>> GetCarsByColorId(int colorId)
        {
            var result = new List<CarDetailDto>();
            var cars = _carDal.GetCarDetails().ToList();
            foreach (var car in cars)
            {
                if (car.ColorId==colorId)
                {
                    result.Add(car);
                }
            }
            return new SuccessDataResult<List<CarDetailDto>>(result.ToList());
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.Updated);
        }
    }
}
