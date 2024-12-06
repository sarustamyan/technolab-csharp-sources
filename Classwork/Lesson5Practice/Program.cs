//int[] a = new int[0] { };

//int max = int.MinValue;
//for (int i = 0; i < a.Length; i++)
//{
//    if (max < a[i])
//    {
//        max = a[i];
//    }
//}
//Console.WriteLine(max);

//string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";

//int quantity = 0;
//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] == ' ')
//    {
//        quantity++;
//    }
//}

//Console.WriteLine(quantity);

//string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";

//int quantity = 0;
//for (int i = 0; i < text.Length; i++)
//{
//    char ch = text[i];
//    if (ch == ' ')
//    {
//        quantity++;
//    }
//}

//Console.WriteLine(quantity);

string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";

int quantity = 0;
foreach (var ch in text)
{
    if (ch == ' ')
    {
        quantity++;
    }
}

Console.WriteLine(quantity);