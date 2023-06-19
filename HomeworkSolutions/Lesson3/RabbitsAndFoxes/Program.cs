int numberOfYears = 100;
int rabbits = 100;
double rabbitBirthRate = 0.2;
double foxKillRate = 0.005;
int foxes = 10;
double foxBirthRate = 0.001;
double foxDeathRate = 0.2;

for (int i = 0; i <= numberOfYears; i++)
{
    // This is called ternary conditional operator: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
    int rabbitsPrev = rabbits > 0 ? rabbits : 0;
    int foxesPrev = foxes > 0 ? foxes : 0;
    // String interpolation can be used here (https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated)
    Console.WriteLine("Year " + i + ". Rabbits: " + rabbits + ", Foxes: " + foxes);
    rabbits = rabbitsPrev + (int)Math.Round(rabbitsPrev * rabbitBirthRate) - (int)Math.Round(rabbitsPrev * foxesPrev * foxKillRate);
    foxes = foxesPrev + (int)Math.Round(foxesPrev * rabbitsPrev * foxBirthRate) - (int)Math.Round(foxesPrev * foxDeathRate);    
}