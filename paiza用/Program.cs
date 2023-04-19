using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] a = { 3, 5, 2, 1, 4 };
        int count = 5;
        int point = 0;

        for (int i = 0; i < count; i++)
        {
            int min = a[i];

            for (int k = i + 1; k < count; k++)
            {
                if (min > a[k])
                {
                    min = a[k];
                    point = k;
                }
            }
            a[point] = a[i];
            a[i] = min;
        }

        a.ToList().ForEach(x => Console.WriteLine(x));
    }
}