void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count - 1)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.WriteLine($"{col[position]}");
}
int IndexOff(int[] collec, int find)
{
    int lenght = collec.Length;
    int index = 0;
    while (index < lenght)
    {
        if (find == collec[index])
        {
            return index;
        }
        index++;
    }
    return -1;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
int find = 4;
Console.WriteLine(IndexOff(array, find));