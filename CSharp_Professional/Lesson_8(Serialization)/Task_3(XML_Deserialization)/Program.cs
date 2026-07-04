using System.Xml.Serialization;
using Task_2_XML_Serialization_;

namespace Task_3_XML_Deserialization_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string filePathEmployee = @"..\..\..\..\Employee.xml";
            string filePathEmployeeXmlAttribute = @"..\..\..\..\EmployeeXmlAttribute.xml";
            DeserializeEmployee<Employee>(filePathEmployee);
            Console.WriteLine(new string('-', 50));
            DeserializeEmployee<EmployeeXmlAttribute>(filePathEmployeeXmlAttribute);
            Console.WriteLine(new string('-', 50));

            static void DeserializeEmployee<T>(string filePath)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (FileStream stream = new FileStream(
                    filePath,
                    FileMode.Open,
                    FileAccess.Read))
                {
                    T employee = (T)serializer.Deserialize(stream)!;

                    Console.WriteLine("Об'єкт успішно десеріалізовано.\n");

                    Console.WriteLine(employee);
                    
                }
            }
        }
    }
}
