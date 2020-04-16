using System;

namespace FibonacciSequence
{
    public class FibonacciSequenceApp
    {
        private readonly FibonacciSequenceUI ui;
        private readonly ISequence sequence;

        public FibonacciSequenceApp(FibonacciSequenceUI ui,ISequence sequence)
        {
            this.sequence = sequence;
            this.ui = ui;
        }

        public void Run(string startRange, string endRange)
        {
            var from = GetRange(startRange);
            var to = GetRange(endRange);
                
            GetSequence(from, to);
        }

        private void GetSequence(int start, int end)
        {
            CheckRange(start,end);
            var index = 0;
            var currentNumber = sequence[index];
            var isValid = true;
            var isEmpty = true;

            while (isValid)
            {
                if (currentNumber > start && currentNumber < end)
                {
                    ui.DisplayNumberOfSequence(currentNumber);
                    isEmpty = false;

                    ui.DisplayDelimiter(sequence[index + 1] < end
                        ? FibonacciSequenceUI.Comma
                        : FibonacciSequenceUI.Point);
                }

                if (currentNumber > end)
                {
                    isValid = false;
                }

                index++;
                currentNumber = sequence[index];
            }

            if (isEmpty)
            {
                ui.DisplayResult(FibonacciSequenceUI.EmptySequence);
            }
        }

        private void CheckRange(int start, int end)
        {
            if (start < 0)
            {
                throw new ArgumentException("Must be greater than zero", nameof(start));
            }

            if (end < 0)
            {
                throw new ArgumentException("Must be greater than zero", nameof(end));
            }

            if (start > end)
            {
                throw new ArgumentException("Second range must be greater or equal than first range",nameof(end));
            }
        }

        private int GetRange(string range)
        {
            if (int.TryParse(range, out var numRange))
            {
                return numRange;
            }
            
            throw new FormatException("Incorrect format");
        }
    }
}