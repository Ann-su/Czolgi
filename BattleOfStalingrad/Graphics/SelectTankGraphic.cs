using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfStalingrad
{
    internal class SelectTankGraphic
    {
        public static void DrawSelectTank()
        {
            GraphicMiscellaneous.DrawAscii(AsciiAssets.KV1, 20, 17);
            GraphicMiscellaneous.DrawAscii(AsciiAssets.KV2, 20, 27);
            Console.SetCursorPosition(20, 48);
            Console.Write("Use WASD and Space");
            GraphicMiscellaneous.DrawAscii(AsciiAssets.KV1Description, 75, 15);
            GraphicMiscellaneous.DrawAscii(AsciiAssets.KV2Description, 75, 25);
        }
    }
}
