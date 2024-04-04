int[] sortedArray = new int[] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, };

List<int> result = new List<int>();
for (int i = 0; i < sortedArray.Length; i++)
    if (sortedArray[i] == sortedArray[i] + 1 && sortedArray[i] + 1 != sortedArray.LastOrDefault())
        result.Add(sortedArray[i]);

Console.WriteLine(result);


int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine(a + b);