using System.Diagnostics.CodeAnalysis;
using System.Numerics;
double sum = 0;
double sumsquare = 0;
for (int i = 1; i <= 100; i++)
{
    sum = i * i + sum;

}

for (int j = 1; j <= 100; j++)
{
   sumsquare = sumsquare + j;

}
sumsquare = sumsquare * sumsquare;
Console.WriteLine(sum);
Console.WriteLine(sumsquare);
double Total = sumsquare - sum;
Console.WriteLine(Total);
Console.ReadLine();