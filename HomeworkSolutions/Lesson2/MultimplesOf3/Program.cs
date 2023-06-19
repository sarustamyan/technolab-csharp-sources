// Unnecessary steps
//int sum = 0;
//for (int i = 0; i <= 100; i++)
//{
//    if (i % 3 == 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);

int sum = 0;
for (int i = 3; i <= 100; i += 3)
{
    sum += i;
}
Console.WriteLine(sum);