using System;

namespace CommonFunctions
{
    public class NumericFunctions
    {
        public int Add(params int []num)
        {
            int sum = 0;
            foreach (int temp in num)
                sum += temp;
            return sum;

        }
        public bool IsEven(int num)
        {
            return num % 2 == 0 ? true : false;
        }
    }
}
