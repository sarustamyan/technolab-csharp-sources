//var items = new int[] { 1, 2, 3, 4, 5 };
//items.Count();
//var text = String.Join(", ", items);

//Console.WriteLine(text);

var listGlobal = new List<int> { 1, 7, 3, 4, 5 };

//Console.WriteLine(String.Join(", ", list));

//list.Remove(1);
//list.Count();

//Console.WriteLine(String.Join(", ", list));

// !!DANGEROUS, try not to mutate the list inside the loop
//for (int i = 0; i < list.Count(); i++)
//{
//    if (IsOdd(list[i]))
//    {
//        list.Remove(list[i]);
//        i--;
//    }
//}

//void RemoveAll(List<int> list, Predicate<int> condition)
//{
//    for (int i = 0; i < list.Count(); i++)
//    {
//        if (condition(list[i]))
//        {
//            list.Remove(list[i]);
//            i--;
//        }
//    }
//}

//bool IsOdd(int number)
//{
//    return number % 2 == 1;
//}

//RemoveAll(listGlobal, IsOdd);

//Console.WriteLine(String.Join(", ", listGlobal));

int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] {1, 2, 3 };
jaggedArray[1] = new int[5];



int MatrixSum(List<List<int>> matrix)
{
    var sum = 0;
    for (int i = 0; i < matrix.Count(); i++)
    {
        sum += ListSum(matrix[i]);
    }
    return sum;
}

int ListSum(List<int> list)
{
    var sum = 0;
    for (int j = 0; j < list.Count(); j++)
    {
        sum += list[j];
    }
    list = new List<int> { 4, 5, 6 };
    return sum;
}

//List<List<int>> jaggedList = new List<List<int>>();
//jaggedList.Add(new List<int> { 1, 2, 3 });
//jaggedList.Add(new List<int> { 4, 5, 6 });
//jaggedList.Add(new List<int> { 7, 8, 9 });

//Console.WriteLine(MatrixSum(jaggedList));

var list = new List<int> { 1, 2, 3 };

ListSum(list);

Console.WriteLine(list[0]);

int Sum(int param1, int param2)
{
    var sum = param1 + param2;
    param1 = 0;
    return sum;
}

var a = 5;
var b = 8;

Sum(a, b);

Console.WriteLine(a);
