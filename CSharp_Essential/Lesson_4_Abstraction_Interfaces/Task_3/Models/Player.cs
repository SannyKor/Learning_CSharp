using System;
using System.Collections.Generic;
using System.Text;
using Task_3.Interfaces;

namespace Task_3.Models
{
    internal class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Відтворення");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Пауза програвання");
        }
        
        void IPlayable.Stop()
        {
            Console.WriteLine("Зупинка програвання");
        }
        public void Record()
        {
            Console.WriteLine("Запис");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Пауза запису");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Зупинка запису");
        }
    }
}
