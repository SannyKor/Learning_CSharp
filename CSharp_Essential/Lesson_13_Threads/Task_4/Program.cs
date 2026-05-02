


RecursiveThreads(5);

static void RecursiveThreads(int depth)
{
    if (depth == 0)
        return;
    Thread thread = new Thread(() =>
    {
        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}, Depth: {depth}");
        RecursiveThreads(depth - 1);
    });
    thread.Start();
}