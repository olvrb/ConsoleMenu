using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    public class Console2
    {
        public static int ConsoleMenu(string titel, string[] options)
        {
            bool hasSelectedValue = false;
            int currentIndex = 0;

            while (!hasSelectedValue)
            {
                Console.Clear();

                Console.WriteLine(titel);

                for (int i = 0; i < options.Length; i++)
                {
                    if (currentIndex == i)
                    {
                        Console.WriteLine(options[i] + " <-");
                    }
                    else
                    {
                        Console.WriteLine(options[i]);
                    }

                }

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                {
                    currentIndex--;
                    if (currentIndex < 0)
                    {
                        currentIndex = 0;
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    currentIndex++;
                    if (currentIndex >= options.Length)
                    {
                        currentIndex = options.Length - 1;
                    }
                }
                else if (key == ConsoleKey.Enter)
                {
                    hasSelectedValue = true;
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
            return currentIndex;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] olikaVal = {"Hello", "Hejsan", "Salut" };
            int val = Console2.ConsoleMenu("Menu title", olikaVal);
            Console.WriteLine("You chose alternative " + (val + 1) + ": " + olikaVal[val]);
            Console.ReadLine();
        }
        /*
        static int ConsoleMenu(string titel, string[] options)
        {
            bool hasSelectedValue = false;
            int currentIndex = 0;

            while (!hasSelectedValue)
            {
                Console.Clear();

                Console.WriteLine(titel);

                for (int i = 0; i < options.Length; i++)
                {
                    if (currentIndex == i)
                    {
                        Console.WriteLine(options[i] + " <-");
                    }
                    else
                    {
                        Console.WriteLine(options[i]);
                    }

                }

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                {
                    currentIndex--;
                    if (currentIndex < 0)
                    {
                        currentIndex = 0;
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    currentIndex++;
                    if (currentIndex >= options.Length)
                    {
                        currentIndex = options.Length - 1;
                    }
                }
                else if (key == ConsoleKey.Enter)
                {
                    hasSelectedValue = true;
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
            return currentIndex;
        }*/
    }
}
