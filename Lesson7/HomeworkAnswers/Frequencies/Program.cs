Dictionary<char, int> GetFrequencies(string text)
{
    Dictionary<char, int> frequencies = new Dictionary<char, int>();
    foreach (var character in text)
    {
        if (frequencies.ContainsKey(character))
        {
            frequencies[character] = frequencies[character] + 1;
        }
        else
        {
            frequencies[character] = 1;
        }
    }
    return frequencies;
}

GetFrequencies("Hello, world!");