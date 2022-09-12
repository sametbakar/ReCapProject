using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length < 2)
                return new ErrorResult(Messages.CarNameInvalid);
            else
                _brandDal.Add(brand);
            return new SuccessResult(Messages.CarAdded);
        }
        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.CarDeleted);
        }
        public IDataResult<Brand> GetBrandById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.BrandId == brandId), Messages.CarListed);
        }
        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
