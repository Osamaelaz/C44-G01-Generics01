using System;

namespace Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.Requirements:  Create a generic class named Range<T> where T represents the type of values. Implement a constructor that takes the minimum and maximum values to define the range.Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.
            try
            {
                Console.WriteLine("Integer Range:");
                Range<int> intRange = new Range<int>(5, 25);
                Console.WriteLine($"Min: {intRange.Min}, Max: {intRange.Max}");
                Console.WriteLine($"Is 20 in range? {intRange.IsInRange(20)}");
                Console.WriteLine($"Length: {intRange.Length()}");

                Console.WriteLine();

                Console.WriteLine("Double Range:");
                Range<double> doubleRange = new Range<double>(1.5, 6.2);
                Console.WriteLine($"Min: {doubleRange.Min}, Max: {doubleRange.Max}");
                Console.WriteLine($"Is 4.5 in range? {doubleRange.IsInRange(4.5)}");
                Console.WriteLine($"Length: {doubleRange.Length()}");

                Console.WriteLine();


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            #endregion

        }
    }
}
