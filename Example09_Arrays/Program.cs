int Max3(int a, int b, int c)
{
    int max = a;
    if (max < b) max = b;
    if (max < c) max = c;
    return max;
}

int[] array = { 14, 62, 23, 54, 95, 16, 78, 38, 49 };

int max = Max3(
    Max3(array[0], array[1], array[2]),
    Max3(array[3], array[4], array[5]),
    Max3(array[6], array[7], array[8]));

Console.WriteLine($"max = {max}");