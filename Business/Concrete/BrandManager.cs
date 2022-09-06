using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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

        public void Add(Brand color)
        {
            _brandDal.Add(color);
        }

        public void Delete(Brand color)
        {
            _brandDal.Delete(color);
        }

        public Brand GetBrandById(int brandId)
        {
            return _brandDal.Get(p => p.BrandId == brandId);
        }

        public void Update(Brand color)
        {
            _brandDal.Update(color);
        }
    }
}
