using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfStalingrad
{
    internal class GameOverSceneGraphic
    {
        public static void DrawScoreTable(List<string> names, List<int> scores, int playerRank)
        {
            int size = scores.Count;
            if (size > 5) size = 5;
            Console.SetCursorPosition(92, 18);
            Console.Write("Greatest Soldiers");

            for (int i = 0; i < 15; i++)
            {
                Console.SetCursorPosition(80, 20 + i);
                Console.WriteLine("|                                      |");
            }

            for (int i = 0; i < 6; i++)
            {
                Console.SetCursorPosition(81, 19 + 3 * i);
                Console.WriteLine("______________________________________");
            }

            for (int i = 0; i < size; i++)
            {
                Console.SetCursorPosition(82, 21 + 3 * i);
                Console.Write((i + 1) + ".\t" + names[i]);
                Console.SetCursorPosition(113, 21 + 3 * i);
                Console.Write(scores[i]);
            }

            Console.SetCursorPosition(92, 38);
            Console.Write("Your ranking is " + playerRank);

            Console.SetCursorPosition(89, 42);
            Console.Write("Press space to continue");

            GraphicMiscellaneous.DrawAscii(AsciiAssets.Tree, 135, 20);
        }
    }
}
