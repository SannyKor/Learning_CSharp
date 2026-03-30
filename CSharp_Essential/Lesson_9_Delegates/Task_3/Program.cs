

Random random = new Random();
RandomDelegate[] delegates = new RandomDelegate[10];
for (int i = 0; i < delegates.Length; i++)
{
    delegates[i] = () => random.Next(0, 100);
}

GetAverageDelegate average = (RandomDelegate[] array) =>
{
    int sum = 0;
    foreach (var del in array)
        sum += del();
    return (double)sum/array.Length;
};

var result = average(delegates);
Console.WriteLine(result);


public delegate int RandomDelegate();
public delegate double GetAverageDelegate(RandomDelegate[] array);