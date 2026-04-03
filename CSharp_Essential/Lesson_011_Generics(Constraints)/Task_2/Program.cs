using Task_2;
Console.OutputEncoding = System.Text.Encoding.Unicode;

CarsCollection carsPark = new CarsCollection();

carsPark.AddCar(new Car(2020, "Tesla Model S"));
carsPark.AddCar(new Car(2018, "BMW X5"));
carsPark.AddCar(new Car(2019, "Audi A4"));
carsPark.AddCar(new Car(2021, "Mercedes-Benz C-Class"));
carsPark.AddCar(new Car(2017, "Toyota Camry"));
carsPark.AddCar(new Car(2022, "Porsche 911"));

for (int i = 0; i < carsPark.Count; i++)
    Console.WriteLine($"Машина {i + 1}: {carsPark[i]}");
Console.WriteLine("Загальна кількість машин у парку: " + carsPark.Count);
Console.WriteLine($"Машина за індексом 4: \n\tрік:\t{carsPark[4-1].Year}; \n\tмодель: {carsPark[4-1].Model}");

Console.WriteLine("Видаляємо всі машини з парку:");
carsPark.RemoveCollection();
Console.WriteLine("Загальна кількість машин у парку: " + carsPark.Count);

