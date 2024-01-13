List<int> Intersection(List<int> items1, List<int> items2)
{ 
    List<int> result = new List<int>();
    HashSet<int> set = new HashSet<int>(items2);
    foreach (int item1 in items1)
    {
        if (set.Contains(item1))
        { 
            result.Add(item1);            
        }
    }
    return result;
}

bool Contains(List<int> items, int value)
{
    foreach (int item in items)
    {
        if (value == item)
        {
            return true;
        }
    }

    return false;
}

void PrintList(List<int> items)
{
    Console.Write(string.Join(", ", items));
}

var a1 = new List<int>();
var a2 = new List<int>();

for (int i = 0; i < 100000; i++)
{
    a1.Add(i);
    a2.Add(i);
}


var intersection = Intersection(a1, a2);

PrintList(intersection);
