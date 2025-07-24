using System;

namespace Assigment
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T min, T max)
        {
            if (min == null || max == null)
                throw new ArgumentNullException("Min and Max values cannot be null.");

            if (min.CompareTo(max) > 0)
                throw new ArgumentException("Minimum value must be less than or equal to the maximum value.");

            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value), "Value cannot be null.");

            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public dynamic Length()
        {
            try
            {
                return (dynamic)Max - (dynamic)Min;
            }
            catch (Exception)
            {
                throw new InvalidOperationException("An error occurred while calculating the length.");
            }
        }
    }
}
