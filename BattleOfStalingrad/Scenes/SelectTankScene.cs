using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Input;

namespace BattleOfStalingrad
{
    internal class SelectTankScene
    {
        public static int sceneId = 3;
        private static int position = 0;
        private static string chosenTank;
        public static string ChosenTank
        {
            get { return chosenTank; }
            set { chosenTank = value; }
        }
        private static int Position
        {
            get { return position; }
            set { if (value >= 0 && value <= 1) position = value; }
        }
        public static void Start()
        {
            GameManager.ActiveSceneId = 3;
            GraphicMiscellaneous.EraseRectangle(1, 1, 195, 48);
            SelectTankGraphic.DrawSelectTank();
            MenuSceneGraphic.DrawCursor(Position);
        }
        public static void KeyPressed(Key key)
        {
            if (key == Key.Space)
            {
                if (Position == 0) chosenTank = AsciiAssets.KV1; 
                if (Position == 1) chosenTank = AsciiAssets.KV2;
                MenuScene.Start();
                return;
            }
            if (key == Key.W) Position = Position - 1;
            if (key == Key.S) Position = Position + 1;
            MenuSceneGraphic.DrawCursor(Position);
        }
    }
}
