int[] array = { 145, 62, 23, 54, 95, 216, 78, 38, 49, 47, 8, 0, 345 };

int n = array.Length;

Console.WriteLine("Введите число.");
Console.Write("num = ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 0;
int found = -1;
while (index < n)
{
    if (num == array[index])
    {
        found = index;
        break;
    }
    index++;
}
if (found == -1) Console.WriteLine("В массиве нет такого числа");
else Console.WriteLine($"Позиция числа в массиве {found + 1}");