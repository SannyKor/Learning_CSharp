using Task_2;

Console.CursorVisible = false;


for (int i = 0; i < 10; i++)
{
    MatrixColumn column = new MatrixColumn();
    Thread thread = new Thread(column.Run);
    thread.Start();
    Thread.Sleep(Random.Shared.Next(50, 500));
}