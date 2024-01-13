var items = new List<int>() { 1, 2, 3 };

List<List<int>> Subsets(List<int> items)
{
    if (items.Count() == 0)
    {
        return new List<List<int>>() { items };
    }

    var lastItem = items.Sum();//.Last();
    var subsets1 = Subsets(items.Take(items.Count() - 1).ToList());
    var subsets2 = new List<List<int>>();
    foreach (var subset in subsets1)
    {
        var subsetCopy = subset.ToList();
        subsetCopy.Add(lastItem);
        subsets2.Add(subsetCopy);
    }
    return subsets1.Concat(subsets2).ToList();
}

var result = Subsets(items);
Console.ReadLine();