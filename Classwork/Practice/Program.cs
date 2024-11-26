//while (true)
//{
//    Console.WriteLine("Input number 1:");
//    int number1 = int.Parse(Console.ReadLine());
//    Console.WriteLine("Input number 2:");
//    int number2 = int.Parse(Console.ReadLine());

//    int sum = number1 + number2;
//    Console.WriteLine("Sum: " + sum);
//    Console.WriteLine("To start over, press Enter");
//    Console.ReadLine();
//    Console.Clear();
//}

// Print all the numbers from 1 to 20.
//int i = 1;
//while (i <= 20)
//{
//    Console.WriteLine(i);
//    i++;
//}

// Refactor the “Progress Bar” solution using a while loop.
//Console.CursorVisible = false;
//Console.BackgroundColor = ConsoleColor.Black;
//Console.WriteLine("Task in progress...");
//Console.BackgroundColor = ConsoleColor.White;

//int i = 0;
//while (i < 20)
//{
//    Console.Write(" ");
//    Thread.Sleep(200);
//    i++;
//}

//Console.WriteLine();
//Console.BackgroundColor = ConsoleColor.Black;
//Console.WriteLine("Finished");

// Calculate the sum of all the numbers from 1 to 100
//int i = 1;
//int sum = 0;
//while (i <= 100)
//{
//    sum += i;
//    i++;
//};
//Console.WriteLine(sum);

int sum = 0;
for (int i = 1; i <= 100; i++)
{
    sum += i;
}
Console.WriteLine(sum);