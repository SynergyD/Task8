using System;
using log4net;

namespace FibonacciSequence
{
    internal class Program
    {
        private static readonly ILog log = LogHelper.GetLogger();
        
        public static void Main(string[] args)
        {
            ISequence sequence = new FibonacciSequence();
            var ui = new FibonacciSequenceUI();
            var app = new FibonacciSequenceApp(ui, sequence);

            try
            {
                app.Run(args[0], args[1]);
            }
            catch (IndexOutOfRangeException exception)
            {
                ui.DisplayResult(FibonacciSequenceUI.Instruction);
                log.Error(exception);
            }
            catch (ArgumentException exception)
            {
                ui.DisplayResult(FibonacciSequenceUI.Mistake);
                ui.DisplayResult(FibonacciSequenceUI.Instruction);
                log.Error(exception);
            }
            catch (FormatException exception)
            {
                ui.DisplayResult(FibonacciSequenceUI.Mistake);
                ui.DisplayResult(FibonacciSequenceUI.Instruction);
                log.Error(exception);
            }
        }
    }
}