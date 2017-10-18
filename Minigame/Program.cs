using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minigame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int x = 14;
            int y = 5;

            ConsoleKey key = ConsoleKey.Zoom;
            do
            {
                if (key == ConsoleKey.LeftArrow)
                {
                    x--;
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    x++;
                }
                else if (key == ConsoleKey.UpArrow)
                {
                    y--;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    y++;
                }

                x = Math.Max(x, 0);
                x = Math.Min(x, Console.WindowWidth - 1);
                y = Math.Max(y, 0);
                y = Math.Min(y, Console.WindowHeight - 1);

                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write('@');

                key = Console.ReadKey().Key;
         } while (true);
        }
    }
}
