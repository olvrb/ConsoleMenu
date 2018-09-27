using System;
using System.Drawing;
using Console = Colorful.Console;

namespace PrgGr6 {
    public class ConsoleMenu {
        public ConsoleMenu(string[] options) {
            FinalIndex = NewMenu(options);
        }

        public int FinalIndex { get; }

        private static int NewMenu(string[] options) {
            bool hasSelectedValue = false;
            int  currentIndex     = 0;

            while (!hasSelectedValue) {
                Console.Clear();


                for (int i = 0; i < options.Length; i++) {
                    if (currentIndex == i) {
                        Console.WriteLine(options[i] + "  <",
                            Color.FromArgb(0, ColorConstants.R, ColorConstants.G, ColorConstants.B));
                    }
                    else {
                        Console.WriteLine(options[i]);
                    }
                }


                switch (Console.ReadKey(true).Key) {
                    case ConsoleKey.UpArrow: {
                        currentIndex--;
                        if (currentIndex < 0) {
                            currentIndex = 0;
                        }

                        break;
                    }

                    case ConsoleKey.DownArrow: {
                        currentIndex++;
                        if (currentIndex >= options.Length) {
                            currentIndex = options.Length - 1;
                        }

                        break;
                    }
                    case ConsoleKey.Enter: {
                        hasSelectedValue = true;
                        break;
                    }
                }
            }

            return currentIndex;
        }
    }
}