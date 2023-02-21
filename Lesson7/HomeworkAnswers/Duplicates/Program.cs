List<int> RemoveDuplicates1(List<int> items)
{
    List<int> result = new List<int> { };
    foreach (var item in items)
    {
        int i = 0;
        for (i = 0; i < result.Count(); i++)
        {
            if (item == result[i])
            {
                break;
            }
        }
        if (i == result.Count())
        {
            result.Add(item);
        }
    }
    return result;
}

List<int> RemoveDuplicates2(List<int> items)
{
    List<int> result = new List<int> { };
    foreach (var item in items)
    {
        if (!result.Contains(item))
        {
            result.Add(item);
        }
    }
    return result;
}


List<int> RemoveDuplicates3(List<int> items)
{
    HashSet<int> result = new HashSet<int> { };
    foreach (var item in items)
    {
        if (!result.Contains(item))
        {
            result.Add(item);
        }
    }
    return result.ToList();
}

var bigList = new List<int> { };

for (var i = 0; i < 100000; i++)
{
    bigList.Add(i);
}

var noDuplicates = RemoveDuplicates3(bigList);
Console.ReadLine();
