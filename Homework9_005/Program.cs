// Написать программу возведения числа А в целую стень B
int s (int b, int a, int sum)
{
    if (b!=0) return s(b - 1,a,sum=sum*a);
    Console.WriteLine();
    Console.WriteLine(sum);
    return 0;
}

Console.Clear();
int sum=1;
Console.Write("Введите число : ");
int a=int.Parse(Console.ReadLine()!);
Console.Write("Введите степень : ");
int b=int.Parse(Console.ReadLine()!);

s(b,a,sum);
Console.WriteLine();
