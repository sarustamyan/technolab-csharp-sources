List<List<int>> Subsets(List<int> items)
{
    var result = new List<List<int>>();
    if (items.Count == 0)
    {
        result.Add(items);
        return result;
    }

    var subsets = Subsets(items.Take(items.Count - 1).ToList());
    foreach (var subset in subsets)
    {
        result.Add(subset.ToList());
    }
    foreach (var subset in subsets)
    {
        subset.Add(items[items.Count - 1]);
        result.Add(subset);
    }
    return result;
}

Subsets(new List<int>() { 1, 2, 3 });