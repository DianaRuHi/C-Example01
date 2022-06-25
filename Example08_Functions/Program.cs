int Max3(int a, int b, int c)
{
    int max = a;
    if (max < b) max = b;
    if (max < c) max = c;
    return max;
}
Console.WriteLine("Введите 9 целых чисел.");
Console.Write("n1 = ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("n2 = ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("n3 = ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.Write("n4 = ");
int n4 = Convert.ToInt32(Console.ReadLine());
Console.Write("n5 = ");
int n5 = Convert.ToInt32(Console.ReadLine());
Console.Write("n6 = ");
int n6 = Convert.ToInt32(Console.ReadLine());
Console.Write("n7 = ");
int n7 = Convert.ToInt32(Console.ReadLine());
Console.Write("n8 = ");
int n8 = Convert.ToInt32(Console.ReadLine());
Console.Write("n9 = ");
int n9 = Convert.ToInt32(Console.ReadLine());

int max = Max3(Max3(n1, n2, n3), Max3(n4, n5, n6), Max3(n7, n8, n9));

Console.WriteLine($"max = {max}");