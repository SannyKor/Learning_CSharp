
using Task_3;

Console.OutputEncoding = System.Text.Encoding.Unicode;

MyDictionary<string, int> myDict = new MyDictionary<string, int>();

myDict.Add("яблуко", 5);
myDict.Add("банан", 10);

Console.WriteLine("Яблуко: " + myDict["яблуко"]);   
Console.WriteLine("Банан: " + myDict["банан"]);  

Console.WriteLine("Кількість елементів в списку: " + myDict.Count);
myDict.Remove("яблуко");
Console.WriteLine("Видаляємо яблуко зі списку. Кількість елементів після видалення:" + myDict.Count);