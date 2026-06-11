
Console.OutputEncoding = System.Text.Encoding.Unicode;

var directory = new DirectoryInfo("TestDirectory");
if (!directory.Exists)
{
    directory.Create();
}

for(int i = 0; i<100; i++)
{
    var subDir = directory.CreateSubdirectory($"Folder_{i}");
    subDir.Refresh();
    if(subDir.Exists)
    {
        Console.WriteLine($"Створена директорія з ім'ям {subDir.Name}:" +
            $" \n\t{subDir.FullName}");
    }
    else
    {
        Console.WriteLine("Помилка при створенні директорії.");
    }
}
Console.WriteLine(new string('*', 50));
Console.WriteLine("Натисніть Enter щоб видалити створені директорії.");
Console.ReadLine();
if(!directory.Exists)
{
    Console.WriteLine("Директорія не існує.");
}
else
{
    DirectoryInfo[] subDirs = directory.GetDirectories();
    foreach(var subDir in subDirs)
    {
        if(subDir.Name.StartsWith("Folder_"))
        {
            subDir.Delete(true);
            Console.WriteLine($"Директорія {subDir.Name} видалена.");
        }
    }
}
