// Написать программу вычисления функции Аккермана.


int AkkFun(int n,int m)
{ 
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return AkkFun(n - 1, 1);
    else
        return AkkFun(n - 1, AkkFun(n, m - 1));
}
Console.Clear();
Console.WriteLine();
Console.Write("Введите значение n (до 3): ");
int n=int.Parse(Console.ReadLine()!);
Console.Write("Введите значение m (до 3): ");
int m=int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.WriteLine($"Значение функции Аккермана равно : {AkkFun(m, n)}");
Console.WriteLine();
