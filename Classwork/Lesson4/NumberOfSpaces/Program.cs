string text = "Hello world !";
int numberOfSpaces = 0;
foreach (char ch in text)
{
    if (ch == ' ')
    {
        numberOfSpaces++;
    }
}
Console.WriteLine(numberOfSpaces);