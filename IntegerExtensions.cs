using System;
using System.Collections.Generic;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            if (a == 0 || b == 0 || a == 1 || b == 1)
            {
                return 1;
            }
            if (a % b == 0)
            {
                return b;
            }
            if (b % a == 0)
            {
                return a;
            }
            if (a == 2 && b % 2 != 0)
            {
                return 1;
            }
            if (b == 2 && b % 2 != 0)
            {
                return 1;
            }
            if (a == 2 || b == 2)
            {
                return 2;
            }
            int result = 1;
            List<int> listOfSamples = new List<int>(new int[] { 2 });
            for (int i = 3; i < a && i < b; i += 2)
            {
                listOfSamples.Add(i);
                for (int j = 0; j < listOfSamples.Count - 1; j++)
                {
                    if (i % listOfSamples[j] == 0)
                    {
                        listOfSamples.Remove(i);
                        break;
                    }
                }
            }
            for (int i = 0; i < listOfSamples.Count; i++)
            {
                if (listOfSamples[i] > a || listOfSamples[i] > b)
                {
                    break;
                }
                if ((a % listOfSamples[i] == 0) && (b % listOfSamples[i] == 0))
                {
                    result = result * listOfSamples[i];
                    b = b / listOfSamples[i];
                    a = a / listOfSamples[i];
                    i--;
                }
            }
            return result;
        }
    }
}
