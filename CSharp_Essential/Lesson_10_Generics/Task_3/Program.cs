using System.Xml.Linq;
using Task_3;

Console.OutputEncoding = System.Text.Encoding.Unicode;

Human human = new("Людина", "Джоні");
Elf elf = new("Ельф", "Генрі");
Dwarf dwarf = new("Гном", "Балін");

MagicBag<ICreature> magic = new();

Console.WriteLine(magic.GetGift(human));
Console.WriteLine(magic.GetGift(elf));
Console.WriteLine(magic.GetGift(dwarf));
Console.WriteLine(magic.GetGift(human));
