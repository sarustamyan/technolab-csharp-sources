List<List<int>> matrix = new List<List<int>>();

matrix.Add(new List<int>() { 1, 2, 3 });
matrix.Add(new List<int>() { 4, 5, 6 });
matrix.Add(new List<int>() { 7, 8, 9 });

PrintList(Diagonal(matrix));

List<int> Diagonal(List<List<int>> matrix)
{
    List<int> diagonal = new List<int>();
    int n = matrix.Count();
    for (int i = 0; i < matrix.Count(); i++)
    {        
        diagonal.Add(matrix[i][n - 1 - i]);
    }
    return diagonal;
}

void PrintList(List<int> items)
{
    foreach (int item in items)
    {
        Console.WriteLine(item);
    }
}