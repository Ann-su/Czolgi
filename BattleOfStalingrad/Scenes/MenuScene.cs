using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Input;

namespace BattleOfStalingrad
{
    internal class MenuScene
    {
        public static int sceneId = 0;
        private static int position = 0;
        private static int Position
        {
            get { return position; }
            set { if (value >= 0 && value <= 2) position = value; }
        }
        public static void Start()
        {
            GameManager.ActiveSceneId = 0;
            GraphicMiscellaneous.EraseRectangle(1, 1, 195, 48);
            MenuSceneGraphic.DrawMenu();
            MenuSceneGraphic.DrawCursor(Position);
        }
        public static void KeyPressed(Key key)
        {
            if (key == Key.Space)
            {
                if (Position == 0) { GameplayScene.Start(); return; }
                if (Position == 1) { SelectTankScene.Start(); return; }
                GameManager.isRunning = false;
            }

            if (key == Key.W) Position = Position - 1;
            if (key == Key.S) Position = Position + 1;
            MenuSceneGraphic.DrawCursor(Position);
        }
    }
}
