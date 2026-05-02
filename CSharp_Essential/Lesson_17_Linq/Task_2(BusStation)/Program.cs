using Task_2;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<Car> cars = new List<Car> 
{
    new Car { Brand = "Toyota", Model = "Camry", Year = 2020, Color = "Red" },
    new Car { Brand = "Honda", Model = "Civic", Year = 2019, Color = "Blue" },
    new Car { Brand = "Ford", Model = "Mustang", Year = 2021, Color = "Black" },
    new Car { Brand = "Tesla", Model = "Model 3", Year = 2022, Color = "White" },
    new Car { Brand = "BMW", Model = "X5", Year = 2018, Color = "Silver" },
    new Car { Brand = "Audi", Model = "A4", Year = 2020, Color = "Gray" },
    new Car { Brand = "Mercedes-Benz", Model = "C-Class", Year = 2019, Color = "Blue" }
};
List<Customer> customers = new List<Customer>
{
    new Customer { Name = "Alice", Phone = "123-456-7890", PurchasedModel = "Camry" },
    new Customer { Name = "Bob", Phone = "987-654-3210", PurchasedModel = "Civic" },
    new Customer { Name = "Charlie", Phone = "555-555-5555", PurchasedModel = "Mustang" },
    new Customer { Name = "David", Phone = "111-222-3333", PurchasedModel = "Model 3" },
    new Customer { Name = "Eve", Phone = "444-444-4444", PurchasedModel = "X5" },
    new Customer { Name = "Frank", Phone = "666-666-6666", PurchasedModel = "A4" },
    new Customer { Name = "Grace", Phone = "777-777-7777", PurchasedModel = "C-Class" }
};

var query = from customer in customers
            join car in cars on customer.PurchasedModel equals car.Model
            where customer.Name == "Grace"
            select new
            {
                CustomerName = customer.Name,
                CustomerPhone = customer.Phone,
                CarBrand = car.Brand,
                CarModel = car.Model,
                CarYear = car.Year,
                CarColor = car.Color
            };

foreach (var item in query)
{
    Console.WriteLine($"Customer Name: {item.CustomerName}");
    Console.WriteLine($"Customer Phone: {item.CustomerPhone}");
    Console.WriteLine($"Car Brand: {item.CarBrand}");
    Console.WriteLine($"Car Model: {item.CarModel}");
    Console.WriteLine($"Car Year: {item.CarYear}");
    Console.WriteLine($"Car Color: {item.CarColor}");
}