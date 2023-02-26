using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Input;

namespace BattleOfStalingrad
{
    internal class GameManager
    {
        public static int framerate = 20;
        public static bool isRunning = true;
        private static int activeSceneId = 0;

        private static Key[] keys = new Key[5] { Key.W, Key.A, Key.S, Key.D, Key.Space };
        private static bool[] pressedKeys = new bool[5] { false, false, false, false, false };
        public static int ActiveSceneId
        {
            get { return activeSceneId; }
            set { if (value >= 0) activeSceneId = value; }
        }

        public static void Start()
        {
            SelectTankScene.ChosenTank = AsciiAssets.KV2;
            MenuScene.Start();
            Thread thread1 = new Thread(GameLoop);
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();
        }

        static void GameLoop()
        {
            double time1 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            while (isRunning)
            {
                // update keys
                for (int i = 0; i < 5; i++)
                {
                    if (Keyboard.IsKeyDown(keys[i]))
                    {
                        // key down
                        if (ActiveSceneId == GameplayScene.sceneId) GameplayScene.KeyDown(keys[i]);

                        if (!pressedKeys[i])  //moment wciśnięcia
                        {
                            // key pressed
                            pressedKeys[i] = true;
                            if (ActiveSceneId == MenuScene.sceneId) MenuScene.KeyPressed(keys[i]);
                            else if (ActiveSceneId == GameplayScene.sceneId) GameplayScene.KeyPressed(keys[i]);
                            else if (ActiveSceneId == GameOverScene.sceneId) GameOverScene.KeyPressed(keys[i]);
                            else if (ActiveSceneId == SelectTankScene.sceneId) SelectTankScene.KeyPressed(keys[i]);
                        }
                    }

                    else pressedKeys[i] = false;
                }

                // update functions
                if (ActiveSceneId == GameplayScene.sceneId) GameplayScene.Update();

                while (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond < time1) Thread.Sleep(1);
                time1 += 1000.0 / framerate;
            }
        }
    }
}
