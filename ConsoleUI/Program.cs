// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


CarManager carManager = new CarManager(new EfCarDal());

CarDetailTest(carManager);

//CarAdd(carManager);

//GetCarsByBrandId(carManager);

//GetCrasByColorId(carManager);

//carManager.Delete(new Car { CarId = 2002 });




static void CarAdd(CarManager carManager)
{
    Car car1 = new Car { BrandId = 20, ColorId = 4, ModelYear = 2019, DailyPrice=539, Description = "Hyundai i20" };
    Car car2 = new Car { BrandId = 1003, ColorId = 1, DailyPrice = 659, ModelYear = 2020, Description = "Renault Megan" };

    carManager.Add(car1);
    carManager.Add(car2);
}

static void GetCarsByBrandId(CarManager carManager)
{
    Console.WriteLine("------------------------------");
    foreach (var car in carManager.GetCarsByBrandId(17))
    {
        Console.WriteLine(car.Description);
    }
}

static void GetCrasByColorId(CarManager carManager)
{
    Console.WriteLine("------------------------------");
    foreach (var car in carManager.GetCarsByColorId(4))
    {
        Console.WriteLine(car.Description);
    }
}

static void CarDetailTest(CarManager carManager)
{
    foreach (var car in carManager.GetCarDetails())
    {
        Console.WriteLine("{0} / {1} / {2}", car.CarName, car.BrandName, car.ColorName);
    }
}