int[] arr = new int[10];
Random rand = new Random();
for (int i = 0; i < 10; i++)
{
    arr[i] = rand.Next(1, 101);
}

Console.WriteLine("Массив:");
foreach(int num in arr)
{
    Console.Write(num + " ");
}

int evenCount = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        evenCount++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество четных чисел: " + evenCount);