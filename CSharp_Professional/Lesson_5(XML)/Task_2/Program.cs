using System.Reflection.PortableExecutable;
using System.Xml;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            FileStream stream = new FileStream("TelephoneBook.xml", FileMode.Open, FileAccess.Read);
           XmlTextReader xmlReader = new XmlTextReader(stream);
            while(xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Contact")
                {
                    string phoneNumber = xmlReader.GetAttribute("TelephoneNumber");
                    string name = xmlReader.ReadString();
                    Console.WriteLine("Ім'я: {0,-10} | Телефон: {1}", name, phoneNumber);
                }
            }
            xmlReader.Close();
            stream.Close();
        }
    }
}
