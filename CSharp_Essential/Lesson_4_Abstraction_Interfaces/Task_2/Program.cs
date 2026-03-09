using Task_2.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;
bool exit = true;
while (exit)
{
    Console.WriteLine("Введіть розширення файлу (txt, doc, xml):");
    string extension = Console.ReadLine().ToLower();
    AbstractHandler? handler = extension switch
    {
        "xml" => new XMLHandler(),
        "txt" => new TXTHandler(),
        "doc" => new DOCHandler(),
        _ => null
    };
    if (handler != null )
    {
        handler.Open();
        handler.Create();
        handler.Chenge();
        handler.Save();
    }
    else
    {
        Console.WriteLine("Невідомий тип файлу.");
    }

    Console.WriteLine("\nБажаєте продовжити? (y/n)");
    string exitChois = Console.ReadLine().ToLower();
    if (exitChois != "y")
        exit = false;
}