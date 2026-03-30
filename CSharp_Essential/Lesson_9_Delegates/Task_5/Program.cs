
int value1 = 29;
int value2 = 11;
int value3 = 40;

AverageDelegate average = (a, b, c) => (double)(a + b + c) / 3;
double res = average.Invoke(value1, value2, value3);
Console.WriteLine(res);

public delegate double AverageDelegate(int value1, int value2, int value3);
