int sleepMilliseconds = 200;
Console.WriteLine("Task In Progress!");

for (int n = 0; n <= 100; n += 5)
{
    Console.BackgroundColor = ConsoleColor.White;
    for (int i = 0; i < n / 5; i++)
    {
        Console.Write(" ");        
    }
    Console.BackgroundColor = ConsoleColor.Black;
    for (int i = 0; i < (100 - n) / 5; i++)
    {
        Console.Write(" ");
        
    }
    Console.Write(" " + n + "%\r");
    Thread.Sleep(sleepMilliseconds);
}
Console.Write("\r\nFinished!");