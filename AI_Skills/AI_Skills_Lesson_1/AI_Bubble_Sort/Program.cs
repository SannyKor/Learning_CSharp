using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 5, 2, 8, 1, 9, 3 };

        Console.WriteLine("Original: " + string.Join(", ", numbers));

        List<int> sortedNumbers = BubbleSort(numbers);

        Console.WriteLine("Sorted:   " + string.Join(", ", sortedNumbers));
    }

    static List<int> BubbleSort(List<int> input)
    {
        // Work on a copy to avoid modifying the original list if desired
        List<int> list = new List<int>(input);
        
        bool swapped;

        for (int i = 0; i < list.Count - 1; i++)
        {
            swapped = false;
            // The last i elements are already in place
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    // Swap elements
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were swapped in the inner loop, the list is sorted
            if (!swapped)
                break;
        }

        return list;
    }
}