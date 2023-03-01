// Показать натуральные числа от M до N, N и M заданы

void PrintTill (int n)
{
    if(n<=25)
    { 
        PrintTill (n+1);
        Console.Write($"{n}\t");
    }
}
int n=10;
Console.Clear();
Console.WriteLine();
PrintTill (n);
Console.WriteLine();
Console.WriteLine();
