using System;
using System.Collections.Generic;
using System.Text;

static class Collection
{

    public static List<T> Shuffle<T>(this List<T> ary)
    {
        Random random = new Random();
        int length = ary.Count;

        try
        {
            for (int i = length - 1; i > 0; i--)
            {
                int r = random.Next(0, i + 1);
                T temp = ary[i];
                ary[i] = ary[r];
                ary[r] = temp;
            }
        }
        catch when (ary == null)
        {
            throw new ArgumentNullException();
        }
        return ary;
    }
}