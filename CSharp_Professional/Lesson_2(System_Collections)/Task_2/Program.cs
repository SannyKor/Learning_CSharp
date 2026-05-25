using Task_2;


List<Item> itemsList = new List<Item> { 
    new Item { Name = "Laptop", Category = "Electronics" },
    new Item { Name = "Headphones", Category = "Electronics" },
    new Item { Name = "Screwdriver", Category = "Hand tools" },
    new Item { Name = "Coffee Maker", Category = "Home Appliances" },
    new Item { Name = "Blender", Category = "Home Appliances" },
    new Item { Name = "Smartphone", Category = "Electronics" },
    new Item { Name = "Hammer", Category = "Hand tools" },
    new Item { Name = "Vacuum Cleaner", Category = "Home Appliances" },
    new Item { Name = "Tablet", Category = "Electronics" },
    new Item { Name = "Air Fryer", Category = "Home Appliances" },
    new Item { Name = "Wrench", Category = "Hand tools" },
    new Item { Name = "Smartwatch", Category = "Electronics" },
    new Item { Name = "Microwave Oven", Category = "Home Appliances" },
    new Item { Name = "Camera", Category = "Electronics" },
    new Item { Name = "Drill", Category = "Hand tools" },
};
List<Buyer> buyersList = new List<Buyer>{
    NewBuyer("John Doe", itemsList),
    NewBuyer("Jane Smith", itemsList),
    NewBuyer("Alice Johnson", itemsList),
    NewBuyer("Bob Brown", itemsList),
    NewBuyer("Charlie Davis", itemsList),
    NewBuyer("Diana Evans", itemsList),
    NewBuyer("Frank Green", itemsList)
};
foreach(var buyer in buyersList)
{
    Console.WriteLine($"Buyer: {buyer.Name}");
    foreach (var item in buyer.Items)
    {
        Console.WriteLine($"\t{item.Name} ({item.Category})");
    }
    Console.WriteLine(new string('-', 40));
}
Dictionary<string, HashSet<string>> buyerToCategories = new Dictionary<string, HashSet<string>>();
foreach(var buyer in buyersList)
{
    if (!buyerToCategories.ContainsKey(buyer.Name))
    {
        buyerToCategories[buyer.Name] = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
    }
    foreach (var item in buyer.Items)
    {
        buyerToCategories[buyer.Name].Add(item.Category);
    }
}

Random rand = new Random();
Buyer randomBuyer = buyersList[rand.Next(buyersList.Count)];
Console.WriteLine($"\n{randomBuyer.Name} made a purchase in the following categories:");
foreach(var category in buyerToCategories[randomBuyer.Name])
{
    Console.WriteLine($"\t{category}");
}

var buyersOfElectronics = buyerToCategories.Where(kvp => kvp.Value.Contains("Electronics")).Select(kvp => kvp.Key).ToList();
Console.WriteLine("\nElectronics Buyers:");
foreach (var buyer in buyersOfElectronics)
{
    Console.WriteLine($"\t{buyer}");
}


static Buyer NewBuyer (string name, List<Item> items)
{
    Buyer buyer = new Buyer(name);
    Random rand = new Random();
    int itemsCountInPurchase = rand.Next(2, 6);
    for (int i = 0; i < itemsCountInPurchase; i++)
    {
        int randomIndex = rand.Next(items.Count);
        buyer.AddItem(items[randomIndex]);
    }
    return buyer;
}