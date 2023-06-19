string text = "racecar";

for (int i = 0; i <= text.Length / 2; i++)
{
    if (text[i] != text[text.Length - 1 - i])
    {
        Console.WriteLine("false");
        return;
    }
}
Console.WriteLine("true");