namespace Technolab.BigInt
{
    public class Program
    {
        static void Main(string[] args)
        {            
            BigInt value1 = new BigInt(new List<int> { 1 });
            BigInt value2 = new BigInt(new List<int> { 2 });

            value1.Add(value2);
        }
    }
}