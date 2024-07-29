using System;

namespace Assignment_1_advanced_c_
{
    public class Range<T> where T : IComparable<T>
    {
        private readonly T minimum;
        private readonly T maximum;

        public Range(T minimum, T maximum)
        {
            if (minimum == null)
                throw new ArgumentNullException(nameof(minimum));
            if (maximum == null)
                throw new ArgumentNullException(nameof(maximum));

            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException("Minimum value must be less than or equal to the maximum value.");
            }

            this.minimum = minimum;
            this.maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(minimum) >= 0 && value.CompareTo(maximum) <= 0;
        }

        public dynamic Length()
        {
            dynamic min = minimum;
            dynamic max = maximum;
            return max - min;
        }
    }
}