List<int> GetDiagonal(int[][] matrix)
{
    // TODO: implement the logic
    throw new NotImplementedException();
}

var matrix = new[]
{
    new[] { 1, 2, 3 },
    new[] { 4, 5, 6 },
    new[] { 7, 8, 9 }
};

var diagonal = GetDiagonal(matrix);

Console.WriteLine(string.Join(",", diagonal));