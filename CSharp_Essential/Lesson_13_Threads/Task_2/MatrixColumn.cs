using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class MatrixColumn
    {
        int positionY = 0;
        int head2PositionY = 0;
        int body2Length = 0;
        int positionX;
        int positionX2;
        int bodyLength;
        int tailPositionY;
        int tail2PositionY;
        int screenHeight = Console.WindowHeight;

        private static object lockObject = new object();

        public void Run()
        {
            head2PositionY = screenHeight + 1;
            while (true)
            {
                if (Console.WindowHeight != screenHeight)
                {
                    lock (lockObject)
                    {
                        Console.Clear();
                    }
                    screenHeight = Console.WindowHeight;
                    positionY = Random.Shared.Next(-15, 0);
                }
                screenHeight = Console.WindowHeight;
                
                if (positionY == 0)
                {
                    positionX = Random.Shared.Next(0, Console.WindowWidth);

                    bodyLength = Random.Shared.Next(5, 10);
                    
                }
                if (head2PositionY - body2Length >= screenHeight)
                {
                    positionX2 = positionX;
                    head2PositionY = Random.Shared.Next(-15, 0);
                    body2Length = Random.Shared.Next(5, 10);
                }
                DrawHead(screenHeight);
                DrawBody(screenHeight);
                ClearTail(screenHeight);

                positionY++;
                head2PositionY++;
                if (positionY - bodyLength >= screenHeight)
                {
                    positionY = 0;
                }
                
                Thread.Sleep(Random.Shared.Next(0, 50));
            }
        }
        private void DrawHead(int screenHeight)
        {
            lock (lockObject)
            {
                if (positionY < screenHeight)
                {

                    Console.SetCursorPosition(positionX, positionY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write((char)Random.Shared.Next(33, 126));
                }

                if (head2PositionY < screenHeight && head2PositionY >= 0)
                {

                    Console.SetCursorPosition(positionX2, head2PositionY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write((char)Random.Shared.Next(33, 126));

                }
            }
        }

        private void DrawBody(int screenHeight)
        {
            lock (lockObject)
            {
                for (int i = 1; i < bodyLength; i++)
                {
                    int bodyPositionY = positionY - i;
                    if (bodyPositionY >= 0 && bodyPositionY < screenHeight)
                    {

                        Console.SetCursorPosition(positionX, bodyPositionY);
                        Console.ForegroundColor = i < 3 ? ConsoleColor.Green : ConsoleColor.DarkGreen;
                        Console.Write((char)Random.Shared.Next(33, 126));

                    }
                }
                for (int i = 1; i < body2Length; i++)
                {
                    int body2PositionY = head2PositionY - i;
                    if (body2PositionY >= 0 && body2PositionY < screenHeight)
                    {

                        Console.SetCursorPosition(positionX2, body2PositionY);
                        Console.ForegroundColor = i < 3 ? ConsoleColor.Green : ConsoleColor.DarkGreen;
                        Console.Write((char)Random.Shared.Next(33, 126));

                    }
                }
            }
        }
        private void ClearTail(int screenHeight)
        {
            lock (lockObject)
            {
                tailPositionY = positionY - bodyLength;
                if (tailPositionY >= 0 && tailPositionY < screenHeight)
                {

                    Console.SetCursorPosition(positionX, tailPositionY);
                    Console.Write(' ');

                }
                tail2PositionY = head2PositionY - body2Length;
                
                if (tail2PositionY >= 0 && tail2PositionY < screenHeight)
                {

                    Console.SetCursorPosition(positionX2, tail2PositionY);
                    Console.Write(' ');

                }
            }
        }
    }
}

