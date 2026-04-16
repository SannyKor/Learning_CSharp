using Task_1;

using System.ComponentModel.DataAnnotations.Schema;

object lockObj = new object();
Console.ForegroundColor = ConsoleColor.Green;
Console.CursorVisible = false;



for (int i = 0; i < 50; i++)
{
    MatrixColumn column = new MatrixColumn();
    Thread thread = new Thread(column.Run);
    thread.Start();
    Thread.Sleep(Random.Shared.Next(50, 500));
}






