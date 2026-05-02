using Task_3_MyDictionary;

Console.OutputEncoding = System.Text.Encoding.UTF8;

MyDictionary<string, string> myDict = new MyDictionary<string, string>();
myDict.Add("apple", "яблуко");
myDict.Add("book", "книга");
myDict.Add("sun", "сонце");

foreach (var pair in myDict)
{
    Console.WriteLine($"{pair.Key} — {pair.Value}");
}
