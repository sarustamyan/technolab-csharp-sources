var input = "Hello, World!";

input.ToLower();

for (int i = 0; i < input.Length; i++)
{
    char valod = input[i];
    if ('A' <= valod && valod <= 'Z')
    {
        int asciiCode = (int)valod;
        asciiCode += 'a' - 'A';
        char lowercaseValod = (char)asciiCode;
        Console.Write(lowercaseValod);
    }
    else
    {
        Console.Write(valod);
    }
}

foreach (char valod in input)
{
    if ('A' <= valod && valod <= 'Z')
    {
        int asciiCode = (int)valod;
        asciiCode += 'a' - 'A';
        char lowercaseValod = (char)asciiCode;
        Console.Write(lowercaseValod);
    }
    else 
    {
        Console.Write(valod);
    }
}

