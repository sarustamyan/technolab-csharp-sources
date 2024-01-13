List<List<int>> matrix = new List<List<int>>();

matrix.Add(new List<int>() { 1, 2, 3 });
matrix.Add(new List<int>() { 4, 5, 6 });
matrix.Add(new List<int>() { 7, 8, 9 });

int sum = 0;
foreach (List<int> row in matrix)
{
    foreach (int item in row)
    {
        sum += item;
    }
}
Console.WriteLine(sum);

sum = 0;
for (int i = 0; i < matrix.Count(); i++)
{
    for (int j = 0; j < matrix[i].Count(); j++)
    {
        sum += matrix[i][j];
    }
}

Console.WriteLine(sum);