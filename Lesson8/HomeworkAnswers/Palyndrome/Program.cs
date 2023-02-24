bool IsPalyndrome(string text)
{
    if (text.Length <= 1)
    {
        return true;
    }
    if (text[0] != text[text.Length - 1])
    {
        return false;
    }
    else
    {
        return IsPalyndrome(RemoveFirstAndLastCharacters(text));
    }
}

string RemoveFirstAndLastCharacters(string text)
{
    return text.Substring(1, text.Length - 2);
}

Console.WriteLine(IsPalyndrome("racecar"));