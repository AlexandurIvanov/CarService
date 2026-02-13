using CarService.Models.Entities;

namespace CarService.DL.MyStaticDb
{
    internal static class StaticDb
    {
        internal static List<Customer> Customers { get; set; } = new List<Customer>()
        {
            new Customer()
            {
                Id = Guid.NewGuid(),
                Name = "Romeo Bulian",
                Email = "rb@xxx.com"
            },
            new Customer()
            {
                Id = Guid.NewGuid(),
                Name = "Jonathan Joestar",
                Email = "jj@xxx.com"
            }
        };

        internal static List<Car> Cars { get; set; } = new List<Car>()
        {
            new Car()
            {
                Id = Guid.NewGuid(),
                Model = "Toyota Camry",
                Year = 2020

            },
            new Car()
            {
                Id = Guid.NewGuid(),
                Model = "Honda Accord",
                Year = 2019
            }
        };
    }
}
