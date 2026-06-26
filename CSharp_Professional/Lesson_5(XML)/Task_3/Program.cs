using System.Xml;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            FileStream stream = new FileStream("TelephoneBook.xml", FileMode.Open, FileAccess.Read);
            XmlTextReader xmlReader = new XmlTextReader(stream);

            Console.WriteLine("=== СПИСОК НОМЕРІВ ТЕЛЕФОНІВ ===");

            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Contact")
                {
                    string phoneNumber = xmlReader.GetAttribute("TelephoneNumber");
                    if (phoneNumber != null)
                    {
                        Console.WriteLine(phoneNumber);
                    }
                }
            }

            xmlReader.Close();
            stream.Close();

            Console.ReadKey();
        }
    }
}
