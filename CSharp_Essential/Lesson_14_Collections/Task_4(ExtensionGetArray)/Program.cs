using Task_2;
using Task_4_ExtensionGetArray_;

Console.OutputEncoding = System.Text.Encoding.UTF8;

MyList<int> numbers = new MyList<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);


int[] array = numbers.GetArray();
Console.WriteLine("Елементи масиву отриманого за допомогою методу розширення GetArray:");
for  (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}