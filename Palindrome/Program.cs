bool Palindrome(string text)
{
    if (text.Length <= 1)
    {
        return true;
    }

    if (text[0] != text[text.Length - 1])
    {
        return false;
    }

    return Palindrome(text.Substring(1, text.Length - 2));
}

Console.WriteLine(Palindrome("racecara"));