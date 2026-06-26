using Task_2;

Person parentMom = new Person("Em Koch", new DateTime(1930, 1, 1), Gender.Female);
Person parentDad = new Person("John Koch", new DateTime(1937, 4, 10), Gender.Male);
FamilyTree familyTree = new FamilyTree(parentMom, parentDad);

Person JohnChild1 = new Person(parentMom, parentDad, "Alice Koch", new DateTime(1955, 6, 15), Gender.Female);
familyTree.Add(JohnChild1);
Person JohnChild2 = new Person(parentMom, parentDad, "Bob Koch", new DateTime(1958, 9, 20), Gender.Male);
familyTree.Add(JohnChild2);

Person AliceHusband = new Person("David Green", new DateTime(1953, 11, 04), Gender.Male);
familyTree.Add(AliceHusband);
Person AliceChild1 = new Person(JohnChild1, AliceHusband, "Charlie Green", new DateTime(1980, 3, 5 ), Gender.Male);
familyTree.Add(AliceChild1);
Person AliceChild2 = new Person(JohnChild1, AliceHusband, "Diana Green", new DateTime(1983, 7, 11), Gender.Female);
familyTree.Add(AliceChild2);

Person BobWife = new Person("Eva White", new DateTime(1960, 2, 28), Gender.Female);
familyTree.Add(BobWife);
Person BobChild1 = new Person(BobWife, JohnChild2, "Frank Koch", new DateTime(1985, 12, 24), Gender.Male);
familyTree.Add(BobChild1);

Person CharlieWife = new Person("Grace Brown", new DateTime(1982, 5, 14), Gender.Female);
familyTree.Add(CharlieWife);
Person CharlieChild1 = new Person(CharlieWife, AliceChild1, "Hannah Green", new DateTime(2005, 8, 22), Gender.Female);
familyTree.Add(CharlieChild1);
Person CharlieChild2 = new Person(CharlieWife, AliceChild1, "Ian Green", new DateTime(2008, 2, 10), Gender.Male);
familyTree.Add(CharlieChild2);

Person DianaHusband = new Person("Jack Finch", new DateTime(1980, 1, 1), Gender.Male);
familyTree.Add(DianaHusband);
Person DianaChild1 = new Person(DianaHusband, AliceChild2, "Karen Finch", new DateTime(2010, 4, 5), Gender.Female);
familyTree.Add(DianaChild1);
Person DianaChild2 = new Person(DianaHusband, AliceChild2, "Leo Finch", new DateTime(2012, 10, 30), Gender.Male);
familyTree.Add(DianaChild2);

Person FrankWife = new Person("Mia Davis", new DateTime(1987, 3, 18), Gender.Female);
familyTree.Add(FrankWife);
Person FrankChild1 = new Person(FrankWife, BobChild1, "Nina Koch", new DateTime(2015, 2, 14), Gender.Female);
familyTree.Add(FrankChild1);
Person FrankChild2 = new Person(FrankWife, BobChild1, "Oscar Koch", new DateTime(2018, 12, 5), Gender.Male);
familyTree.Add(FrankChild2);

Console.WriteLine("All members in the family tree:");
var allFamilyMembers = familyTree.Select(p => new { p.Name, p.Birthday}).OrderBy(p => p.Birthday);
int counter = 1;
foreach (var member in allFamilyMembers)
{
    Console.WriteLine($"{counter}. " +
        $"Name: {member.Name}, " +
        $"Birthday: {member.Birthday.ToShortDateString()}");
    counter++;
}
counter = 1;

Console.WriteLine(new string('-', 50));
Console.WriteLine("\nLooking for descendants of David Green:");
var searchResult = familyTree.FirstOrDefault(p => p.Name == "David Green");
if (searchResult != null)
{
    var descendantsOfDavidGreen = familyTree.AllDescendantsOf(searchResult).OrderBy(p => p.Birthday);
    foreach (var descendant in descendantsOfDavidGreen)
    {
        Console.WriteLine($"{counter}. {descendant}");
        counter++;
    }
}
counter = 1;

Console.WriteLine(new string('-', 50));
Console.WriteLine("\nLooking for family members born between 1980 and 1990:");
var bornInTheYears = familyTree.Where(p => p.Birthday.Year >= 1980 && p.Birthday.Year <= 1990)
                               .OrderBy(p => p.Birthday);

foreach (var member in bornInTheYears)
{
    Console.WriteLine($"{counter}. {member}");
    counter++;
}
Console.WriteLine(new string('-', 50));
Console.WriteLine("\nDeleting David Green from the family tree:");
var davidGreen = familyTree.FirstOrDefault(p => p.Name == "David Green");
if (davidGreen != null)
{
    familyTree.Remove(davidGreen);
}
var checkDavidGreen = familyTree.FirstOrDefault(p => p.Name == "David Green");
if (checkDavidGreen == null)
{
    Console.WriteLine("David Green has been successfully removed from the family tree.");
}
else
{
    Console.WriteLine("Failed to remove David Green from the family tree.");
}