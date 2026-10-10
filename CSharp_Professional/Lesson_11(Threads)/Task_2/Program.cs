using System.IO;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string resultPath = "result.txt";
            string file1Path = "file1.txt";
            string file2Path = "file2.txt";
            File.WriteAllText(resultPath, string.Empty);

            File.WriteAllLines(file1Path, new string[]
            {
                "Перший рядок першого файлу",
                "Другий рядок першого файлу",
                "Третій рядок першого файлу"
            });

            File.WriteAllLines(file2Path, new string[]
            {
                "Перший рядок другого файлу",
                "Другий рядок другого файлу",
                "Третій рядок другого файлу"
            });
            FileOperator fileOperator = new FileOperator(resultPath);

            Thread thread1 = new Thread(fileOperator.FileOperatorMethod);
            Thread thread2 = new Thread(fileOperator.FileOperatorMethod);

            thread1.Name = "Потік 1";
            thread2.Name = "Потік 2";

            thread1.Start(file1Path);
            thread2.Start(file2Path);
            thread1.Join();
            thread2.Join();

            Console.WriteLine();
            Console.WriteLine("Усі потоки завершили роботу.");
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Вміст файлу result.txt:");
            string[] resultText = File.ReadAllLines(resultPath);
            foreach(string line in resultText)
            {
                Console.WriteLine(line);
            }
        }
    }
}
