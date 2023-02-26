using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BattleOfStalingrad
{
    internal class GraphicMiscellaneous
    {
        public static void DrawAscii(string str, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            int i = 0;
            while (i < str.Length)
            {
                Console.Write(str[i]);
                if (str[i] == '\n') Console.SetCursorPosition(x, Console.CursorTop);
                i++;
            }
        }

        public static void EraseRectangle(int x, int y, int width, int height)
        {
            char[] chars = new char[width];
            for (int i = 0; i < width; i++) chars[i] = ' ';

            for (int j = y; j < y + height; j++)
            {
                Console.SetCursorPosition(x, j);
                Console.Write(chars);
            }
        }

        public static void DrawBorders(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                Console.SetCursorPosition(2 * i, 0);
                Console.Write('#');
            }

            for (int i = 0; i < y; i++)
            {
                Console.SetCursorPosition(2 * x, i);
                Console.Write('#');
            }

            for (int i = x; i >= 0; i--)
            {
                Console.SetCursorPosition(2 * i, y);
                Console.Write('#');
            }

            for (int i = y; i >= 0; i--)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('#');
            }
        }
    }
}
