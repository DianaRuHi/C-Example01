// Сортировка массива выбором минимального

Console.WriteLine("Hello, World!");

int[] array = { 1, 4, 5, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] ar)
{
    int length = ar.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{ar[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minIn = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minIn]) minIn = j;
        }
        int exch = arr[i];
        arr[i] = arr[minIn];
        arr[minIn] = exch;
    }
}
PrintArray(array);
SelectionSort(array);
PrintArray(array);
