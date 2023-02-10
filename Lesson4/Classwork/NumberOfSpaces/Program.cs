var text = "asdas dfsadf  as, sd";

var quantity = 0;
foreach (var character in text)
{
    if (character == ' ')
    {
        quantity++;
    }
}
Console.WriteLine(quantity); 