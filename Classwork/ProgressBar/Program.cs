Console.CursorVisible = false;
Console.WriteLine("Task in progress...");

int numberOfSteps = 20;

for (int step = 1; step <= numberOfSteps; step++)
{
    Console.BackgroundColor = ConsoleColor.White;
    for (int i = 0; i < step; i++)
    {
        Console.Write(" ");
    }

    Console.BackgroundColor = ConsoleColor.Black;
    for (int i = 0; i < numberOfSteps - step; i++)
    {
        Console.Write(" ");
    }
    Console.Write(" " + step * 100 / numberOfSteps + "%\r");
    Thread.Sleep(200);
}
Console.WriteLine("Finished!");