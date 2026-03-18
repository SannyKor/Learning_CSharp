
Random random = new Random();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(0, 100);

Console.WriteLine("Створено масив:");
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i],4}");
Console.WriteLine();
int max = array[0];
int min = array[0];
int sum = 0;
Console.WriteLine("\nНепарнi числа:");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
    if (array[i] < min)
        min = array[i];
    sum += array[i];
    if (array[i] % 2 != 0)
        Console.Write($"{array[i],4}");
}
Console.WriteLine($"\nМаксимальное число: {max}");
Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Середнє арифметичне чисел: {sum/array.Length}");