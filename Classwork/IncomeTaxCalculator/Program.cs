(double Limit, double Rate) bracket0 = (0, 0.1);
(double Limit, double Rate) bracket1 = (11000.0, 0.12);
(double Limit, double Rate) bracket2 = (44725.0, 0.22);
(double Limit, double Rate) bracket3 = (95375.0, 0.24);
(double Limit, double Rate) bracket4 = (182100.0, 0.32);
(double Limit, double Rate) bracket5 = (231250.0, 0.35);
(double Limit, double Rate) bracket6 = (578125.0, 0.37);

double income = 58000.0;
double tax = 0;

tax += 10;
tax = tax + 10;

#region Attempt 1

if (income <= bracket1.Limit)
{
    tax += (income - bracket0.Limit) * bracket0.Rate;
}
else
{
    tax += (bracket1.Limit - bracket0.Limit) * bracket0.Rate;

    if (income <= bracket2.Limit)
    {
        tax += (income - bracket1.Limit) * bracket1.Rate;
    }
    else
    {
        tax += (bracket2.Limit - bracket1.Limit) * bracket1.Rate;

        if (income <= bracket3.Limit)
        {
            tax += (income - bracket2.Limit) * bracket2.Rate;
        }
    }
}

Console.WriteLine(tax);

#endregion

#region Attempt 2

if (income <= bracket1.Limit)
{
    tax += (income - bracket0.Limit) * bracket0.Rate;
    Console.WriteLine(tax);
    return;
}

tax += (bracket1.Limit - bracket0.Limit) * bracket0.Rate;
if (income <= bracket2.Limit)
{
    tax += (income - bracket1.Limit) * bracket1.Rate;
    Console.WriteLine(tax);
    return;
}

tax += (bracket2.Limit - bracket1.Limit) * bracket1.Rate;
if (income <= bracket3.Limit)
{
    tax += (income - bracket2.Limit) * bracket2.Rate;
    Console.WriteLine(tax);
    return;
}

#endregion