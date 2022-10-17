using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers
                             on r.CustomerId equals c.CustomerId
                             join u in context.Users
                             on c.UserId equals u.Id
                             join b in context.Brands
                             on r.RentalId equals b.BrandId
                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 BrandName = b.BrandName,
                                 FirstName = u.FirstName,
                                 LastName=u.LastName
                             };
                return result.ToList();
            }
        }
    }
}
