List<int> GetDiagonal(int[][] matrix)
{
    var diagonal = new List<int> { };
    for (var i = 0; i < matrix.Count(); i++)
    {
        diagonal.Add(matrix[i][i]);
    }
    return diagonal;
}

List<int> GetReverseDiagonal(int[][] matrix)
{
    var diagonal = new List<int> { };
    for (var i = 0; i < matrix.Count(); i++)
    {
        diagonal.Add(matrix[i][matrix.Count() - i - 1]);
    }
    return diagonal;
}

var matrix = new[]
{
    new[] { 1, 2, 3 },
    new[] { 4, 5, 6 },
    new[] { 7, 8, 9 }
};

var diagonal = GetDiagonal(matrix);

Console.WriteLine(string.Join(",", diagonal));