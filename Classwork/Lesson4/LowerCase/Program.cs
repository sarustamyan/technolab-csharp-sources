string text = "Hello World!";
string lowercaseText = "";

//for (int i = 0; i < text.Length; i++)
//{
//    if ('A' <= text[i] && text[i] <= 'Z')
//    {
//        lowercaseText += (char)((int)text[i] + 32);
//    }
//    else
//    {
//        lowercaseText += text[i];
//    }
//}

foreach (char ch in text)
{
    if ('A' <= ch && ch <= 'Z')
    {
        lowercaseText += (char)((int)ch + 32);
    }
    else
    {
        lowercaseText += ch;
    }
}

Console.WriteLine(lowercaseText);