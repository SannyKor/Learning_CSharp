using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class FileOperator
    {
        private static readonly object locker = new object();
        private readonly string resultPath;
        public FileOperator(string resultPath)
        {
            this.resultPath = resultPath;
        }
        public void FileOperatorMethod(object? fileName)
        {
            if (fileName == null)
            {
                return;
            }
            string filePath = fileName.ToString()!;
            Console.WriteLine($"Потік: {Thread.CurrentThread.Name} - обробка файлу: {filePath}");
            string[] lines = File.ReadAllLines(filePath);
            foreach(string line in lines)
            {
                Thread.Sleep(500);
                lock(locker)
                {
                    File.AppendAllText(resultPath, $"{Thread.CurrentThread.Name} : {line}{Environment.NewLine}");
                    Console.WriteLine($"Потік: {Thread.CurrentThread.Name} - обробка рядка: {line}");
                }
            }
            Console.WriteLine($"Потік: {Thread.CurrentThread.Name} - обробка файлу завершена: {filePath}");
        }
    }
}
