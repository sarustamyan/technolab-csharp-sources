Console.CursorVisible = false;
Console.WriteLine("Task in progress...");

var length = 20;
for (var i = 1; i <= length; i++)
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.Write("\r");
    Console.Write("".PadRight(i));
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Write("".PadRight(length - i));
    Console.Write($" {i * (100 / length)}%");
    Thread.Sleep(200);
}

Console.WriteLine();
Console.WriteLine("Finished.");