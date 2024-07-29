using System;
namespace Assignment_1_advanced_c_
{
    class Program
    {
        
            #region Non-Generic VS Generic SWAP

            // Non-Generic SWAP
            public static void Swap(ref object a, ref object b)
            {
                object temp = a;
                a = b;
                b = temp;
            }

            // Generic SWAP
            public static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }

            /* 
            Generic SWAP advantages:
            1. Type safety at compile-time
            2. Avoids boxing/unboxing for value types
            3. Better performance for value types
            */

            #endregion

            #region Generic Search Array

            public static int SearchArray<T>(T[] array, T item) where T : IComparable<T>
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].CompareTo(item) == 0)
                    {
                        return i;
                    }
                }
                return -1;
            }

            /*
            This generic method searches for an item in an array:
            1. Works with any type T that implements IComparable<T>
            2. Returns the index of the first occurrence or -1 if not found
            3. Utilizes the CompareTo method for comparison
            */

            #endregion

            #region Equality (Class and Struct)

            public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Person p = (Person)obj;
                return Name == p.Name && Age == p.Age;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Name, Age);
            }
        }

        /*
        Equality implementation for a class:
        1. Override Equals method for custom comparison logic
        2. Override GetHashCode to maintain consistency with Equals
        3. Consider implementing IEquatable<T> for better performance
        */

        #endregion

            #region Generics - BubbleSort

        public static void BubbleSort<T>(T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        /*
        Generic BubbleSort implementation:
        1. Works with any type T that implements IComparable<T>
        2. Uses CompareTo method for element comparison
        */

        #endregion

            #region is Conditional Operator

        public static void ProcessObject(object obj)
        {
            if (obj is string str)
            {
                Console.WriteLine($"String length: {str.Length}");
            }
            else if (obj is int num)
            {
                Console.WriteLine($"Integer value: {num}");
            }
            else
            {
                Console.WriteLine("Unknown type");
            }
        }

        /*
        'is' operator usage:
        1. Checks if an object is of a specific type
        2. Allows pattern matching and variable declaration in one step
        3. Enhances code readability and reduces explicit casting
        */

        #endregion

            #region as Casting Operator

        public static void PrintLength(object obj)
        {
            string str = obj as string;
            if (str != null)
            {
                Console.WriteLine($"Length: {str.Length}");
            }
            else
            {
                Console.WriteLine("Not a string");
            }
        }

        /*
        'as' operator usage:
        1. Attempts to cast an object to a specified type
        2. Returns null if the cast is not possible
        3. Safer alternative to direct casting, avoiding exceptions
        */

        #endregion

            #region IComparable VS Generic IComparable

        // Non-generic IComparable
        public class Book : IComparable
        {
            public string Title { get; set; }
            public int PageCount { get; set; }

            public int CompareTo(object obj)
            {
                if (obj == null) return 1;

                Book otherBook = obj as Book;
                if (otherBook != null)
                    return this.PageCount.CompareTo(otherBook.PageCount);
                else
                    throw new ArgumentException("Object is not a Book");
            }
        }

        // Generic IComparable<T>
        public class GenericBook : IComparable<GenericBook>
        {
            public string Title { get; set; }
            public int PageCount { get; set; }

            public int CompareTo(GenericBook other)
            {
                if (other == null) return 1;

                return this.PageCount.CompareTo(other.PageCount);
            }
        }

        /*
        IComparable vs IComparable<T>:
        1. Generic version provides type safety at compile-time
        2. Avoids boxing/unboxing for value types
        3. Eliminates the need for runtime type checking and casting
        4. Improves performance and reduces potential for errors
        */

        #endregion
    }
}