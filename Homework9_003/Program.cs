// Найти сумму цифр числа

int SumNumber (int number)
{
    if(number<1) return 0;
    return SumNumber(number/10)+number%10;
}

Console.Clear();
Console.WriteLine();
Console.Write("Введите N: ");
int number=int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(SumNumber(number));
Console.WriteLine();
