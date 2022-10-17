// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


CarManager carManager = new CarManager(new EfCarDal());

//CarDetailTest(carManager);

//CarAdd(carManager);

//GetCarsByBrandId(carManager);

//GetCrasByColorId(carManager);

//carManager.Delete(new Car { CarId = 2002 });

UserAddTest();

CustomerAddTest();

RentalAddTest();

static void CarAdd(CarManager carManager)
{
    Car car1 = new Car { BrandId = 20, ColorId = 4, ModelYear = 2019, DailyPrice = 539, Description = "Hyundai i20" };
    Car car2 = new Car { BrandId = 1003, ColorId = 1, DailyPrice = 659, ModelYear = 2020, Description = "Renault Megan" };

    carManager.Add(car1);
    carManager.Add(car2);
}

static void GetCarsByBrandId(CarManager carManager)
{
    var result = carManager.GetCarsByBrandId(17);
    Console.WriteLine("------------------------------");
    foreach (var car in result.Data)
    {
        Console.WriteLine(car.Description);
    }
}

static void GetCrasByColorId(CarManager carManager)
{
    var result = carManager.GetCarsByColorId(4);
    Console.WriteLine("------------------------------");
    foreach (var car in result.Data)
    {
        Console.WriteLine(car.Description);
    }
}

static void CarDetailTest(CarManager carManager)
{
    var result = carManager.GetCarDetails();
    foreach (var car in result.Data)
    {
        Console.WriteLine("{0} / {1} / {2}", car.CarName, car.BrandName, car.ColorName);
    }
    Console.WriteLine(result.Message);
}

static void UserAddTest()
{
    User user1 = new User { FirstName = "Davolio", LastName = "Laura", Email = "davalio1234@gmail.com" };
    User user2 = new User { FirstName = "Pedro", LastName = "Afonso", Email = "pedro1234@gmail.com" };

    UserManager userManager = new UserManager(new EfUserDal());

    //userManager.Add(user1);
    userManager.Add(user2);
}

static void CustomerAddTest()
{
    Customer customer1 = new Customer { UserId = 1, CompanyName = "The Big Cheese" };
    Customer customer2 = new Customer { UserId = 2, CompanyName = "The Big Cheese" };

    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
    //customerManager.Add(customer1);
    customerManager.Add(customer2);
}

static void RentalAddTest()
{
    Rental rental1 = new Rental { CustomerId = 1, CarId = 3, RentDate = DateTime.Now };
    Rental rental2 = new Rental { CustomerId = 2, CarId = 1, RentDate = DateTime.Now };

    RentalManager rentalManager = new RentalManager(new EfRentalDal());

    rentalManager.Add(rental1);
    rentalManager.Add(rental2);
}