namespace Assignment_1_advanced_c_
{
    public static class OptimizedBubbleSort
    {
        public static void Sort<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]); // Tuple deconstruction for swapping
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }
    }
}