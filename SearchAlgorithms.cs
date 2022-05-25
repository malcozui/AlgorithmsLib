using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLib;

public class SearchAlgorithms
{
    public static int LinearSearch(int desired_item, int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == desired_item) return i;
        }
        return -1;
    }
    public static int BinarySearch(int desired_item, int[] arr)
    {
        int min = 0;
        int max = arr.Length - 1;

        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (arr[mid] == desired_item) return mid; 
            if (arr[mid] > desired_item) min = mid + 1;
            else max = mid - 1;
        }
        return -1;
    }
}
