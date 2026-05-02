
using Task_3_Clone_;

Console.OutputEncoding = System.Text.Encoding.UTF8;

House house = new House("вул. Пряна, 10", new List<Room>
{
    new Room("Кухня"),
    new Room("Вітальня"),
    new Room("Спальня")
});
Console.WriteLine("Створено будинок:");
Console.WriteLine(house);

Console.WriteLine("\nКлонуємо будинок та міняємо адресу у колоні та додаємо кімнату:");
House clonedHouse = house.Clone();
clonedHouse.Address = "вул. Солодка, 20";
clonedHouse.AddRoom(new Room("Ванна"));
Console.WriteLine(clonedHouse);
Console.WriteLine("Oригінальний будинок після зміни у клоні:");
Console.WriteLine(house);

Console.WriteLine("Робимо глибоку копію будинку змінюємо адресу та додаємо кімнату у копію:");
House deepClonedHouse = house.DeepClone();
deepClonedHouse.Address = "вул. Солодка, 30";
deepClonedHouse.AddRoom(new Room("Дитяча"));
Console.WriteLine(deepClonedHouse);
Console.WriteLine("Cтан оригінального будинку після змін у копії:");
Console.WriteLine(house);


