//int Factorial(int n)
//{
//    int result = 1;
//    for (int i = 1; i <= n; i++)
//    {
//        result *= i;
//    }
//    return result;
//}

namespace Technolab.Recursive
{
    public class FactorialCalculator
    {
        public int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

    }
}

namespace Technolab.Iterative
{
    public class FactorialCalculator
    {
        public int Factorial(int n)
        {
            var factorial = 1;
            for (int i = 1; i <= n; i++)
            { 
                factorial *= i;
            }
            return factorial;
        }

    }
}

//int Factorial4()
//{
//    return 4 * Factorial3();
//}

//int Factorial3()
//{
//    return 3 * Factorial2();
//}

//int Factorial2()
//{
//    return 2 * Facrtorial1();
//}

//int Facrtorial1()
//{
//    return 1;
//}

//Console.WriteLine(Factorial(4));