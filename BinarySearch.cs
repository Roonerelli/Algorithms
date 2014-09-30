using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BinarySearch
    {
        public int Recursive(int[] array, int itemToFind)
        {
            return Recursive(array, 0, array.Length - 1, itemToFind);
        }

        private int Recursive(int[] array, int lowerBound, int upperBound, int itemToFind)
        {
            int midIdx = (upperBound + lowerBound) / 2;
            int midVal = array[midIdx];

            if (midVal == itemToFind)
                return midIdx;

            if (itemToFind > midVal)
                return Recursive(array, midIdx + 1, upperBound, itemToFind);
            
            if (itemToFind < midVal)
                return Recursive(array, lowerBound, midIdx-1, itemToFind);
            
            return -1;
        }

        public int Iterative(int[] array, int itemToFind)
        {
            int first = 0;
            int last = array.Length;

            while (first <= last)
            {
                int midIdx = (first + last)/2;
                int midVal = array[midIdx];

                if (itemToFind > midVal)
                    first = midIdx + 1;

                if (itemToFind < midVal)
                    last = midIdx - 1;

                if (itemToFind == midVal)
                    return midIdx;
            }

            return -1;
        }
    }
}
