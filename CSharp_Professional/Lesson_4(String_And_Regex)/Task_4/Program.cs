using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string fileName = "receipt.txt";
var currentCulture = CultureInfo.CurrentCulture;
var usaCulture = new CultureInfo("en-US");

using (StreamReader reader = new StreamReader(fileName))
{
    string? dateLine = reader.ReadLine();
    var date = DateTime.Parse(dateLine);

    List<(string name, decimal price)> items = new();
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        string[] parts = line.Split(";");
        if (parts.Length == 2)
        {
            items.Add((parts[0], decimal.Parse(parts[1], currentCulture)));
        }
    }
}

