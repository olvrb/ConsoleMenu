using System;

// ReSharper disable once CheckNamespace
namespace PrgGr6 {
    internal static class Program {
        // ReSharper disable once UnusedParameter.Local
        private static void Main(string[] args) {
            /*
             * TESTS
             */
            string[]    choices = {"choice 1", "choice 2", "choice 3"};
            ConsoleMenu menu    = new ConsoleMenu(choices);
            int         val     = menu.FinalIndex;
            Console.WriteLine("alternative " + (val + 1) + ": " + choices[val]);
            Console.ReadKey();
        }
    }
}
