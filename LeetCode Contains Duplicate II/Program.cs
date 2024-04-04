int[] arr = new int[10] { 1, 3, 3, 6, 5, 5, 42, 2, 2, 1 };
int res = 0;

while (true)
{
    int i = 0;
    int j = arr.Length - 1;


    for (; i < arr.Length; i++)
    {
        if (arr[j] == arr[i])
        {
            res = arr[j]; break;
        }
    }
    for (; j >= 0; j--)
    {
        if (arr[j] == arr[i])
        {
            res = arr[j]; break;
        }
    }
}
Console.WriteLine(res);