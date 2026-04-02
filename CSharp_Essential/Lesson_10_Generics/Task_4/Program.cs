using System.Collections;
using System.Collections.Generic;
using Task_2;
using Task_4;

Console.OutputEncoding = System.Text.Encoding.Unicode;

MyList<int> list =  new MyList<int>();
Random random = new Random();
for (int i = 0; i < 10; i++)
    list.Add(random.Next(1, 100)); 

int[] array = list.GetArray();
for (int i = 0; i < array.Length; i++) 
    Console.WriteLine($"Елемент масиву {i}: {array[i]}");