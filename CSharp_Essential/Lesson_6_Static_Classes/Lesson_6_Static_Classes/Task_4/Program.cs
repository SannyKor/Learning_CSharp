using Task_4;


int[] array = new int[10];
Random random = new Random();

for (int i = 0; i < array.Length;  i++)
{
    array[i] = random.Next(1, 100);
}

foreach (int i in array)
{
    Console.WriteLine(i);
}
Console.WriteLine(new string('*', 100));

array.SuperSort();
foreach (int i in array)
{
    Console.WriteLine(i);
}