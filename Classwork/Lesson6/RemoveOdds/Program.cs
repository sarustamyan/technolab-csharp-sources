List<int> list = new List<int>() { 2, 1, 3, 7, 5 };
List<int> list2 = new List<int>();
PrintList(list);
foreach (int item in list)
{
    if (item % 2 == 0)
    {
        list2.Add(item);
    }
}

PrintList(list2);


void PrintList(List<int> list)
{ 
    Console.WriteLine(string.Join(", ", list));
}


var list3 = list.Where(x => x % 2 == 0).ToList();
PrintList(list3);