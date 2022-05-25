namespace AlgorithmsLib;

public class SearchAlgorithms
{
    /// <summary>
    /// Searches and finds the index of the desired Int32
    /// </summary>
    /// <param name="desired_item">the Int32 to be found</param>
    /// <param name="arr">the Int32 array to search</param>
    /// <returns>
    /// The index of the desired item if found, else returns -1
    /// </returns>
    public static int LinearSearch(int desired_item, int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == desired_item) return i;
        }
        return -1;
    }
    /// <summary>
    /// Searches and finds the index of the desired Int32
    /// </summary>
    /// <param name="desired_item">the Int32 to be found</param>
    /// <param name="arr">the Int32 array to search</param>
    /// <returns>
    /// The index of the desired item if found, else returns -1
    /// </returns>
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
