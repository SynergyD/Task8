using System;

namespace FibonacciSequence
{
    public class FibonacciSequenceUI
    {
        #region Constants

        public const string Mistake = "You entered incorrect data";
        public const string Instruction = "Enter two arguments: <From> <To>. Args must be greater than zero and second one must be greater than first";
        public const string EmptySequence = "The are no fibonacci numbers in this range";
        public const string Comma = ", ";
        public const string Point = ".";

        #endregion

        #region Methods

        public void DisplayResult(string result)
        {
            Console.WriteLine(result);
        }

        public void DisplayDelimiter(string delimiter)
        {
            Console.Write(delimiter);
        }

        public void DisplayNumberOfSequence(int number)
        {
            Console.Write(number);
        }

        #endregion
    }
}