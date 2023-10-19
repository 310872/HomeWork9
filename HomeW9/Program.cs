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

