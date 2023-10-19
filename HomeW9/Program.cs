// Вывод натуральных чисел в промежутке от N до 1

void ShowDigital(int n)
{
    if (n >= 1)
    {
        Console.Write(n + "," + " ");
        ShowDigital(n-1);
    }
}
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {n} -> ");
ShowDigital(n);

// Сумма натуральных элементов в промежутке от M до N

int SumNumbers(int m, int n)
{
    if (n > m)
    {
        if (m == n) return m;
    else return n + SumNumbers(m,n-1);
    }
    else
    {
       if (m == n) return n;
    else return m + SumNumbers(m-1,n);
    }
}
Console.WriteLine("Input M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"M = {m}; N = {n} -> {SumNumbers(m,n)}");

