using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class MatrixColumn
    {
        int positionY = 0;
        int positionX;
        int bodyLength;
        int tailPositionY;
        int screenHeight = Console.WindowHeight;

        private static object lockObject = new object();
       
        public void Run()
        {
            while (true)
            {
                if (Console.WindowHeight != screenHeight)
                {
                    lock (lockObject)
                    {
                        Console.Clear();
                    }
                    screenHeight = Console.WindowHeight;
                    positionY = Random.Shared.Next(-20, 0);
                }
                screenHeight = Console.WindowHeight;
                if (positionY == 0)
                {
                    positionX = Random.Shared.Next(0, Console.WindowWidth);
                    bodyLength = Random.Shared.Next(5, 15);
                }
                DrawHead(screenHeight);
                DrawBody(screenHeight);
                ClearTail(screenHeight);

                positionY++;
                if (positionY - bodyLength >= screenHeight)
                {
                    positionY = 0;
                }
                Thread.Sleep(Random.Shared.Next(0, 50));
            }
        }
        private void DrawHead(int screenHeight)
        {
            if (positionY < screenHeight)
            {
                lock(lockObject)
                {
                    Console.SetCursorPosition(positionX, positionY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write((char)Random.Shared.Next(33, 126));
                }
            }
        }
        private void DrawBody(int screenHeight)
        {
            for (int i = 1; i < bodyLength; i++)
            {
                int bodyPositionY = positionY - i;
                if (bodyPositionY >= 0 && bodyPositionY < screenHeight)
                {
                    lock (lockObject)
                    {
                        Console.SetCursorPosition(positionX, bodyPositionY);
                        Console.ForegroundColor = i < 3 ? ConsoleColor.Green : ConsoleColor.DarkGreen;
                        Console.Write((char)Random.Shared.Next(33, 126));
                    }
                }
            }
        }
        private void ClearTail(int screenHeight)
        {
            tailPositionY = positionY - bodyLength;
            if (tailPositionY >= 0 && tailPositionY < screenHeight)
            {
                lock (lockObject)
                {
                    Console.SetCursorPosition(positionX, tailPositionY);
                    Console.Write(' ');
                }
            }
        }
    }
}

