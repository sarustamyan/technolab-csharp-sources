List<int> LuckyNumbers(int[][] matrix)
{
    List<int> luckyNumbers = new List<int>();

    for (int i = 0; i < matrix.Count(); i++)
    {
        for (int j = 0; j < matrix[i].Count(); j++)
        {
            if (IsMaxInColumn(matrix, i, j) && IsMinInRow(matrix, i, j))
            { 
                luckyNumbers.Add(matrix[i][j]);
            }
        }
    }

    return luckyNumbers;
}

bool IsMinInRow(int[][] matrix, int row, int column)
{
    return GetRow(matrix, row).Min() == matrix[row][column];
}

bool IsMaxInColumn(int[][] matrix, int row, int column)
{
    return GetColumn(matrix, column).Max() == matrix[row][column];
}

List<int> GetRow(int[][] matrix, int row)
{
    return matrix[row].ToList();
}

List<int> GetColumn(int[][] matrix, int column)
{
    var list = new List<int>() { };
    for (int i = 0; i < matrix.Count(); i++)
    {
        list.Add(matrix[i][column]);
    }
    return list;
}

var luckyNumbers = LuckyNumbers(new int[][] { new int[] { 3, 7, 8 }, new int[] { 9, 11, 13 }, new int[] { 15, 16, 17 } });

Console.WriteLine(String.Join(",", luckyNumbers));