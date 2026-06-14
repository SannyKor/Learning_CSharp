using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string fileName = "receipt.txt";
var currentCulture = CultureInfo.CurrentCulture;
var usaCulture = new CultureInfo("en-US");

using (StreamReader reader = new StreamReader(fileName))
{