
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using Task_2;

Console.OutputEncoding =  System.Text.Encoding.UTF8;

WebSource source = new WebSource();
string searchFrom = "https://example.com/about";
string data = source.GetSource(searchFrom);
StringBuilder result = new StringBuilder();

result.AppendLine("=== ПОСИЛАННЯ ===");
Regex linkRegex = new Regex(@"https?:\/\/(?!([^\/]+\.)?example\.com\b)[^\s<>""']+", RegexOptions.IgnoreCase);
foreach (Match match in linkRegex.Matches(data))
{
    result.AppendLine(match.Value);
}

result.AppendLine();
result.AppendLine("=== EMAIL ===");
Regex emailRegex = new Regex(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}");
foreach (Match match in emailRegex.Matches(data))
{
    result.AppendLine(match.Value);
}

result.AppendLine();
result.AppendLine("=== ТЕЛЕФОНИ ===");
Regex phoneRegex = new Regex(@"(?:\+?38\(?0|\(?0)\s*\(?\d{2}\)?[\s-]*\d{3}[\s-]*\d{2}[\s-]*\d{2}");
foreach (Match match in phoneRegex.Matches(data))
{
    result.AppendLine(match.Value);
}

string finalResult = result.ToString();
Console.WriteLine(finalResult);
File.WriteAllText("result.txt", finalResult);
Console.WriteLine("Результат збережено у result.txt");
