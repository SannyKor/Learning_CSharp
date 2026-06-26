
Console.OutputEncoding = System.Text.Encoding.Unicode;

string path = "text.txt";

string text1 = "Hello, World!";
string text2 = "The weather is nice today.";
Console.WriteLine($"У файл {path} записуємо текст: \n\t{text1}\n\t{text2}");

StreamWriter writer = new StreamWriter(path);
writer.WriteLine(text1);
writer.WriteLine(text2);
writer.Close();

Console.WriteLine($"Зчитуємо текст з файлу {path}:");
StreamReader reader = new StreamReader(path);
string? line;
while ((line = reader.ReadLine()) != null)
{
    Console.WriteLine($"\t{line}");
}
reader.Close();

Console.WriteLine($"Інформація про файл {path}:");
var file = new FileInfo(path);
Console.WriteLine($"\tРозмір: {file.Length} байт");
Console.WriteLine($"\tДата створення: {file.CreationTime}");
Console.WriteLine($"\tДата останнього доступу: {file.LastAccessTime}");
Console.WriteLine($"\tДата останньої зміни: {file.LastWriteTime}");