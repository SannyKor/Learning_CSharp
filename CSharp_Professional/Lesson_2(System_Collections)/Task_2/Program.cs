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
static Buyer NewBuyer (string name, List<Item> items)
{
    Buyer buyer = new Buyer(name);
    Random rand = new Random();
    for (int i = 0; i < rand.Next(1, 20); i++)
    {
        int randomIndex = rand.Next(items.Count);
        buyer.AddItem(items[randomIndex]);
    }
    return buyer;
}