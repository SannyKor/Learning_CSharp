
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
Regex linkRegex = new Regex(@"href\s*=\s*[""'](?<url>[^""']+)[""']", RegexOptions.IgnoreCase);
foreach (Match match in linkRegex.Matches(data))
{
    string url = match.Groups["url"].Value.Trim();

    // 1. Ігноруємо посилання на пошту (mailto) та телефони (tel)
    if (url.StartsWith("mailto:", StringComparison.OrdinalIgnoreCase) ||
        url.StartsWith("tel:", StringComparison.OrdinalIgnoreCase))
    {
        continue;
    }

    // 2. Ігноруємо посилання-якорі (внутрішня навігація по сторінці) та javascript
    if (url.StartsWith("#") || url.StartsWith("javascript:", StringComparison.OrdinalIgnoreCase))
    {
        continue;
    }

    // 3. Обробка відносних посилань (наприклад, /privacy-policy)
    // Якщо посилання не починається з http/https, перетворюємо його на абсолютне
    if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
        !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
    {
        // Замініть "https://main-site.com" на змінну з адресою сайту, який ви парсите
        string baseUrl = "https://main-site.com";

        if (Uri.TryCreate(new Uri(baseUrl), url, out Uri absoluteUri))
        {
            url = absoluteUri.ToString();
        }
    }

    result.AppendLine(url);
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
Regex phoneRegex = new Regex(@"(\+?\d[\d\s\-\(\)]{7,}\d)");
foreach (Match match in phoneRegex.Matches(data))
{
    result.AppendLine(match.Value);
}

string finalResult = result.ToString();
Console.WriteLine(finalResult);
File.WriteAllText("result.txt", finalResult);
Console.WriteLine("Результат збережено у result.txt");
