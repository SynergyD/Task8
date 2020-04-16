using System;

namespace FibonacciSequence
{
    public class FibonacciSequence : ISequence
    {
        #region Constants

        private const int LastIndexOfSequence = 47;
        private const double GoldenRatio = 1.618033988749895;

        #endregion

        public int this[int index] => GetNumberOfSequence(index);

        #region Methods
        private int GetNumberOfSequence(int index)
        {
            
            if (index > LastIndexOfSequence)
            {
                throw new IndexOutOfRangeException("You have exceeded the maximum index");
            }

            if (index < 0)
            {
                throw new IndexOutOfRangeException("Must be greater than zero");
            }
            
            var result = (Math.Pow(GoldenRatio, index) - Math.Pow(-GoldenRatio, -index))
                         / (2 * GoldenRatio - 1);

            return Convert.ToInt32(result);
        }
        #endregion
    }
}