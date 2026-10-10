using System.Xml.Serialization;

namespace Task_2_XML_Serialization_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string filePathEmployee = @"..\..\..\..\Employee.xml";
            string filePathEmployeeXmlAttribute = @"..\..\..\..\EmployeeXmlAttribute.xml";

            Employee employee = new Employee("Олександр", 39, 35000);
            EmployeeXmlAttribute employeeXmlAttribute = new EmployeeXmlAttribute("Олександр", 39, 35000);

            SerializeEmployee(filePathEmployee, employee);
            Console.WriteLine(new string('-', 50));
            SerializeEmployee(filePathEmployeeXmlAttribute, employeeXmlAttribute);
            Console.WriteLine(new string('-', 50));
        }

        static void SerializeEmployee<T>(string filePath, T employee)
        {                
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using FileStream stream = new FileStream(
                filePath,
                FileMode.Create,
                FileAccess.Write);
            serializer.Serialize(stream, employee);
            stream.Close();

            Console.WriteLine("Об'єкт серіалізовано.");
            string xmlContent = File.ReadAllText(filePath);

            Console.WriteLine("Вміст XML-файлу:");
            Console.WriteLine(xmlContent);
        }
    }
}
