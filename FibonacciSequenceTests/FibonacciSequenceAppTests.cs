using System;
using FibonacciSequence;
using Xunit;

namespace FibonacciSequenceTests
{
    public class FibonacciSequenceAppTests
    {
        [Theory]
        [InlineData("2.3")]
        [InlineData("2,4")]
        [InlineData("k")]
        [InlineData("я")]
        [InlineData("3000000000")]
        public void GetRange_ShouldFail(string endRange)
        {
            ISequence sequence = new FibonacciSequence.FibonacciSequence();
            var ui = new FibonacciSequenceUI();
            var app = new FibonacciSequenceApp(ui, sequence);
            
            Assert.Throws<FormatException>(() => app.Run("1",endRange));
        }

        [Theory]
        [InlineData("-3", "5", "start")]
        [InlineData("5", "-3", "end")]
        [InlineData("100", "50", "end")]
        public void CheckRange_ShouldFail(string start, string end, string argumentName)
        {
            ISequence sequence = new FibonacciSequence.FibonacciSequence();
            var ui = new FibonacciSequenceUI();
            var app = new FibonacciSequenceApp(ui, sequence);

            Assert.Throws<ArgumentException>(argumentName, () => app.Run(start, end));
        }
    }
}