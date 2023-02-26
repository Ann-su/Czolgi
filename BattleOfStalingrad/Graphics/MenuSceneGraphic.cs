using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfStalingrad
{
    internal class MenuSceneGraphic
    {
        public static void DrawMenu()
        {
            GraphicMiscellaneous.DrawAscii(AsciiAssets.Title, 6, 0);
            GraphicMiscellaneous.DrawAscii(AsciiAssets.Play, 20, 15);
            GraphicMiscellaneous.DrawAscii(AsciiAssets.SelectTank, 20, 25);
            GraphicMiscellaneous.DrawAscii(AsciiAssets.Exit, 20, 35);
            GraphicMiscellaneous.DrawAscii(AsciiAssets.MenuTank, 135, 30);            
            Console.SetCursorPosition(20, 48);
            Console.Write("Use WASD and Space");
            GraphicMiscellaneous.DrawBorders(100, 50);
        }

        public static void DrawCursor(int Position)
        {
            GraphicMiscellaneous.EraseRectangle(5, 15, 15, 30);
            GraphicMiscellaneous.DrawAscii(AsciiAssets.Pointer, 5, Position * 10 + 15);
        }
    }
}
