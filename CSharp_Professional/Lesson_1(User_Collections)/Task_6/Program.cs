


Random random = new Random();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 101);
}
List<int> list = new List<int>();
IEnumerable<int> oddSquares = GetOddSquares(array);
foreach (var square in oddSquares)
{
    list.Add(square);
    Console.WriteLine(square);
}

static IEnumerable<int> GetOddSquares(int[] numbers)
{
    foreach (var number in numbers)
    {
        if (number % 2 != 0)
        {
            yield return number * number;
        }
    }
}