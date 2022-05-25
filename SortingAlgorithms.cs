using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLib;

public class SortingAlgorithms
{
    public static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    //tuple swapping.
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
        }
    }
    public static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length -1; i++)
        {
            int min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            //tuple swapping
            (arr[min], arr[i]) = (arr[i], arr[min]);
        }
    }
    public static void CocktailSort(int[] arr)
    {
        bool swapped = true;
        int start = 0;
        int stop = arr.Length;

        while (swapped)
        {
            swapped = false;

            for (int i = start; i < stop - 1; ++i)
            {
                if (arr[i] > arr[i + 1])
                {
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
            swapped = false;
            stop--;

            for (int i = stop - 1; i >= start; i--)
            {
                if (arr[i] > arr[i + 1])
                {
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    swapped = true;
                }
            }
            start++;
        }
    }
    public static void InsertionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int item = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > item)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = item;
        }
    }
}
