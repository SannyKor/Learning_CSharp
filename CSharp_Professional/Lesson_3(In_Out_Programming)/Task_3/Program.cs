

Console.OutputEncoding = System.Text.Encoding.Unicode;

string path = "text.txt";
var file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
var writer = new StreamWriter(file);
for(int i= 0; i < 1000; i++)
{ 
    writer.WriteLine("Hello, World!"); 
}
writer.Close();
var fileInfo = new FileInfo(path);
string? drive = Path.GetPathRoot(fileInfo.FullName);
Console.WriteLine($"Створено файл: \n\t" +
    $"{fileInfo.FullName};\n\t" +
    $"кореневий каталог: {drive};\n\t" +
    $"розмір файлу: {fileInfo.Length} байт;");

Console.WriteLine($"Робимо пошук файла за ім'ям: {path}");
var searchOptions = new EnumerationOptions
{
    IgnoreInaccessible = true,
    RecurseSubdirectories = true,
    MatchCasing = MatchCasing.CaseInsensitive
};
var searchFiles = Directory.EnumerateFiles(drive ?? @"C:\", path, searchOptions);
Console.WriteLine($"Знайдені файли:");
foreach (var sfile in searchFiles)
{
    
    string? sName = Path.GetFileName(sfile);
    string? sdirectoryName = Path.GetFileName(Path.GetDirectoryName(sfile));
    Console.WriteLine($"\t{sName} лежить у каталозі ({sdirectoryName});");
}
Console.WriteLine($"Тепер шукаємо наш файл за розміром ({fileInfo.Length}):");
var searchFile = searchFiles.FirstOrDefault(f => new FileInfo(f).Length == fileInfo.Length);
if (searchFile != null)
{
    var foundFileInfo = new FileInfo(searchFile);
    Console.WriteLine($"Знайдено файл: \n\t" +
    $"{foundFileInfo.FullName};\n\t" +
    $"розмір файлу: {foundFileInfo.Length} байт;");
}
else
{
    Console.WriteLine($"Файл не знайдено за розміром.");
}