

using System.IO.Compression;

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

Console.WriteLine($"\nРобимо пошук на диску {drive} файла за ім'ям: {path}");
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
    Console.WriteLine((new FileInfo(sfile).FullName));
}
Console.WriteLine($"\nТепер із тих що знайшли відсортовуємо наш файл за розміром ({fileInfo.Length}):");
var searchFile = searchFiles.FirstOrDefault(f => new FileInfo(f).Length == fileInfo.Length);
var foundFileInfo = new FileInfo(searchFile ?? string.Empty);
if (searchFile != null)
{
    Console.WriteLine($"Знайдено файл: \n\t" +
    $"{foundFileInfo.FullName};\n\t" +
    $"розмір файлу: {foundFileInfo.Length} байт;");
}
else
{
    Console.WriteLine($"Файл не знайдено за розміром.");
}

Console.WriteLine($"тепер стискаєм файл знайдений файл з розміром {foundFileInfo.Length}:");
string compressedFilePath = foundFileInfo.FullName + ".gz";
FileStream sourceStream = new FileStream(foundFileInfo.FullName, FileMode.Open, FileAccess.Read);
FileStream destinationStream = new FileStream(compressedFilePath, FileMode.Create, FileAccess.Write);
GZipStream compressor = new GZipStream(destinationStream, CompressionMode.Compress);
sourceStream.CopyTo(compressor);
sourceStream.Close();
compressor.Close();
destinationStream.Close();
sourceStream.Close();
var compressedFileInfo = new FileInfo(compressedFilePath);
Console.WriteLine($"Розмір стиснутого файлу: {compressedFileInfo.Length} байт;");

