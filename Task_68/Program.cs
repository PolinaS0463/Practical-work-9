Console.Write("Введите число 1-е неотрицательное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2-е неотрицательное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AkkermanFunction(M, N)); 

int AkkermanFunction(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return AkkermanFunction(M - 1, 1);
    }
    else
    {
        return (AkkermanFunction(M - 1, AkkermanFunction(M, N - 1)));
    }
}