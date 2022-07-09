int FibonachiNumber(int n)
{
    if (n == 1 || n == 2) return 1;
    else return FibonachiNumber(n - 1) + FibonachiNumber(n - 2);
}

for (int i = 1; i < 20; i++)
{
    Console.WriteLine($"F{i} = {FibonachiNumber(i)}");
}
