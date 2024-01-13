string s = "Hello World!";

string lowercase = "";
foreach (char c in s)
{
    if ('A' <= c && c <= 'Z')
    {
        lowercase += (char)((int)c + 32);
    }
    else 
    {
        lowercase += c;
    }
}
Console.WriteLine(lowercase);