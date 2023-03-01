// Найти сумму элементов от M до N, N и M заданы

int SumElement(int a, int b, int sum)
{
    if (a <= b)
    { 
        sum = sum + a;
        a++;
        Console.Write(sum+"  ");
        SumElement(a, b, sum);
    } 
return sum;
}

int a=10;
int b=25;
int sum=0;
Console.WriteLine();
SumElement( a, b, sum);
Console.WriteLine();
Console.WriteLine();


