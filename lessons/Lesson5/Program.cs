string a = "qqq aaa ttt";
int b = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] == ' ')
    {
        b++;
    }
}
Console.WriteLine(b + 1);