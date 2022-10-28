int[] items = new int[] { -1, -2, -45, -16, -77, -8 };
int max = int.MinValue;
for (int i = 0; i < items.Length; i++)
{
    if (items[i] > max)
    { 
        max = items[i];
    }
}
Console.WriteLine(max);