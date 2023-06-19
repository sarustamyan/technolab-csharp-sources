int upperLimit = 12;
int sum = 0;
for (int currentNumber = 2; currentNumber <= upperLimit; currentNumber++)
{
    bool isCurrentNumberPrime = true;
    #region
    for (int i = 2; i <= Math.Sqrt(currentNumber); i++)
    {
        if (currentNumber % i == 0)
        {
            isCurrentNumberPrime = false;
            break;
        }
    }
    #endregion

    if (isCurrentNumberPrime)
    {
        sum += currentNumber;
    }
}

Console.WriteLine(sum);
