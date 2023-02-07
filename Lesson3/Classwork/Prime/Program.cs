//int number = 6;
//int i = 2;
//for (i = 2; i < number; i++)
//{

//    if (number % i == 0)
//    {
//        Console.WriteLine(false);
//        break;
//    }    
//}
//if (i == number)
//{
//    Console.WriteLine(true);
//}


//Console.WriteLine(0.1 + 0.2);

using Microsoft.VisualBasic;
using System;

Console.CursorVisible = false;
Console.WriteLine("Task in progress...");
Console.BackgroundColor = ConsoleColor.White;
var number = 0;
int k;



for (int n = 0; n < 20; n++)
{
    Console.Write(" ");
    Thread.Sleep(200);

}



for (int i = 5; i <= 100; i += 5)
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.SetCursorPosition(21, Console.CursorTop);
    Console.Write(i + "%");
    
    Thread.Sleep(200);
}



Console.WriteLine(" ");
Console.Write("Finished!");
Console.WriteLine(" ");