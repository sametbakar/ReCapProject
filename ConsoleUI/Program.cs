// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


Car car1 = new Car { Id = 6, BrandId = 3, ColorId = 3, DailyPrice = 350, Description = "Mercedes C 200", ModelYear = 2022 };


CarManager carManager = new CarManager(new InMemoryCarDal());

carManager.Add(car1);

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}



Car car2 = carManager.GetById(3);

Console.WriteLine(car2.Description);


