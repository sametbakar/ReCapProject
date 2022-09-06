using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        Brand GetBrandById(int brandId);
        void Add(Brand color);
        void Delete(Brand color);
        void Update(Brand color);
    }
}
