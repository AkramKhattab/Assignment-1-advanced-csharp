using System;
namespace Assignment_1_advanced_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question 1: Optimized Bubble Sort
            Console.WriteLine("Question 1: Optimized Bubble Sort");

            // Initialize an unsorted array of integers
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            // Display the original array using the basic ArrayToString method
            Console.WriteLine($"Original array: {ArrayToString(arr)}");

            // Call the static Sort method from OptimizedBubbleSort class
            OptimizedBubbleSort.Sort(arr);

            // Display the sorted array using the basic ArrayToString method
            Console.WriteLine($"Sorted array: {ArrayToString(arr)}");
            Console.WriteLine();
            #endregion

            #region Question 2: Generic Range<T> Class
            Console.WriteLine("Question 2: Generic Range<T> Class");

            // Create a new Range<int> instance
            // Using 'var' for type inference, as the type is clear from the right side
            var intRange = new Range<int>(1, 10);

            // Test IsInRange method
            // Using string interpolation for cleaner output formatting
            Console.WriteLine($"Is 5 in range? {intRange.IsInRange(5)}");
            Console.WriteLine($"Is 15 in range? {intRange.IsInRange(15)}");

            // Test Length method
            // The Length method returns a dynamic type, which is then implicitly converted to string
            Console.WriteLine($"Range length: {intRange.Length()}");
            #endregion
        }
        #region Helper method to convert array to string
        static string ArrayToString<T>(T[] array)
        {
            if (array == null || array.Length == 0)
                return string.Empty;

            string result = array[0].ToString();
            for (int i = 1; i < array.Length; i++)
            {
                result += ", " + array[i].ToString();
            }
            return result;
            #endregion
        }
    }
}