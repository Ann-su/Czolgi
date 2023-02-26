using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Input;

namespace BattleOfStalingrad
{
    internal class GameplayScene
    {
        public static int sceneId = 1;

        static List<Tank> TankList = new List<Tank>();
        static Tank playerTank = new Tank(15, 100, 15, 15, 5);
        private static int tankNum = 1;
        private static int FuhrerAnger = 0;
        private static int usedBullets = 0;
        static List<Bullet> playerBulletList = new List<Bullet>(); // lista przechowująca pociski wystrzelone przez gracza

        static List<Bullet> enemyBulletList = new List<Bullet>(); // lista przechowująca pociski wystrzelone przez gracza
        public static void Start()
        {
            GameManager.ActiveSceneId = 1;
            GraphicMiscellaneous.EraseRectangle(1, 1, 195, 48);
            playerTank = new Tank(15, 150, 15, 15, 100);
            if (SelectTankScene.ChosenTank == AsciiAssets.KV2) playerTank = new Tank(10, 200, 15, 15, 100);
            TankList.Clear();
            enemyBulletList.Clear();
            playerBulletList.Clear();
            FuhrerAnger = 0;
            usedBullets = 0;
            TankList.Add(new Tank(FuhrerAnger / 10));

            GraphicMiscellaneous.EraseRectangle((int)playerTank.PosX - 4, (int)playerTank.PosY - 4, 30, 15);
            GraphicMiscellaneous.DrawAscii(SelectTankScene.ChosenTank, (int)playerTank.PosX, (int)playerTank.PosY);
        }

        public static void Update()
        {
            // usuwanie poprzednich grafik ----------------------------------------------------------------------------
            foreach (Tank tank in TankList) GraphicMiscellaneous.EraseRectangle((int)tank.PosX + 15, (int)tank.PosY, 8, 7);

            // uaktualnianie ruchów przeciwników ----------------------------------------------------------------------
            foreach (Tank tank in TankList)  // przechodzi przez każdy czołg
            {
                int function = tank.Reload();  // aktualizowanie i odczytanie fazy ładowania
                if (function == 0) tank.Move(Tank.direction.left);  // pocisk się ładuje, czołg jedzie
                else if (function  == 2) enemyBulletList.Add(new Bullet(-tank.bullet_speed * 10, tank.bullet_strength, (int)tank.PosX + 20, (int)tank.PosY + 3));
                if (tank.PosX < 10)  // jeśli czołg wroga dojedzie do bazy
                {
                    MenuScene.Start();
                }
            }

            // uaktualnianie pocisków gracza --------------------------------------------------------------------------
            foreach(Bullet bullet in playerBulletList)
            {
                bullet.Update();
                bool isHit = false;  // zmienna potrzebna, żeby wyjść z obu pętli foreach na raz (break w jednej pętli nie przerwie drugiej)

                if (bullet.speed < 10)  // usuwanie wolnych, zużytych pocisków
                {
                    GraphicMiscellaneous.EraseRectangle((int)bullet.posX - 2, (int)bullet.posY - 2, 4, 4);
                    playerBulletList.Remove(bullet);
                    break;
                }

                // sprawdzanie, czy pocisk nie uderzył w czołg
                foreach (Tank tank in TankList)
                {
                    if (Math.Abs(bullet.posX - tank.PosX) < 3 && Math.Abs(bullet.posY - tank.PosY - 3) < 3)  // jeśli nastąpi uderzenie
                    {
                        // usuwanie trafionego czołgu
                        TankList.Remove(tank);  
                        GraphicMiscellaneous.EraseRectangle((int)tank.PosX - 5, (int)tank.PosY, 25, 7);

                        // zwiększanie poziomu trudności
                        FuhrerAnger++;
                        Console.SetCursorPosition(15, 2);
                        Console.Write("Fuhrer's anger: " + FuhrerAnger);

                        Console.SetCursorPosition(15, 4);
                        int score = 4 * FuhrerAnger - usedBullets;
                        if (score < 0) score = 0;
                        Console.Write("Score: " + score);

                        // wysyłanie kolejnego niemca na śmierć
                        TankList.Add(new Tank(FuhrerAnger / 10));
                        if (tankNum < 3)
                        {
                            tankNum++;
                            TankList.Add(new Tank(FuhrerAnger / 10 + 1));
                        }

                        // usuwanie bohaterskiego pocisku
                        playerBulletList.Remove(bullet);
                        GraphicMiscellaneous.EraseRectangle((int)bullet.posX - 2, (int)bullet.posY - 2, 4, 4);

                        isHit = true;
                        break;
                    }
                }

                if (isHit) break;

                GraphicMiscellaneous.EraseRectangle((int)bullet.posX - 5, (int)bullet.posY, 5, 1);
                Console.SetCursorPosition((int)bullet.posX, (int)bullet.posY);
                Console.Write('=');
            }

            // rysowanie przeciwników ---------------------------------------------------------------------------------
            foreach (Tank tank in TankList)
            {
                GraphicMiscellaneous.DrawAscii(AsciiAssets.Panzer, (int)tank.PosX, (int)tank.PosY);
                Console.SetCursorPosition((int)tank.PosX + 8, (int)tank.PosY + 2);
                Console.Write(tank.newLevel);
            }

            // uaktualnianie pocisków przeciwników
            foreach (Bullet bullet in enemyBulletList)
            {
                bullet.Update();

                if (bullet.speed > -10 || bullet.posX < 5)  // usuwanie wolnych, poza ekranem i zużytych pocisków
                {
                    enemyBulletList.Remove(bullet);
                    break;
                }

                // sprawdzanie, czy pocisk nie uderzył w czołg

                if (Math.Abs(bullet.posX - playerTank.PosX - 15) < 5 && Math.Abs(bullet.posY - playerTank.PosY - 3) < 3)  // jeśli nastąpi uderzenie
                {
                    // usuwanie pocisku
                    GraphicMiscellaneous.EraseRectangle((int)bullet.posX - 2, (int)bullet.posY - 2, 4, 4);
                    enemyBulletList.Remove(bullet);

                    // odejmowanie życia
                    playerTank.hp -= (int)bullet.GetTheObrazenia();
                    Console.SetCursorPosition(15, 6);
                    Console.Write("              "); // czyszczenie poprzedniego hp (bez tego były by błędy: hp po spadku ze 100 do 90 wyświetliło by 900)
                    Console.SetCursorPosition(15, 6);
                    Console.Write("HP: " + playerTank.hp);

                    break;
                }

                GraphicMiscellaneous.EraseRectangle((int)bullet.posX - 2, (int)bullet.posY, 10, 1);
                Console.SetCursorPosition((int)bullet.posX, (int)bullet.posY);
                Console.Write('=');
            }

            if (playerTank.hp <= 0) GameOverScene.Start(4 * FuhrerAnger - usedBullets);
        }

        public static void KeyDown(Key key)
        {
            if (GameManager.ActiveSceneId != sceneId) return;

            switch (key)  // poruszanie czołgiem gracza
            {
                case Key.W: playerTank.Move(Tank.direction.up);     break;
                case Key.S: playerTank.Move(Tank.direction.down);   break;
                case Key.A: playerTank.Move(Tank.direction.left);   break;
                case Key.D: playerTank.Move(Tank.direction.right);  break;
            }

            // rysowanie czołgu gracza
            GraphicMiscellaneous.EraseRectangle((int)playerTank.PosX - 4, (int)playerTank.PosY, 30, 10);
            GraphicMiscellaneous.DrawAscii(SelectTankScene.ChosenTank, (int)playerTank.PosX, (int)playerTank.PosY);
        }

        public static void KeyPressed(Key key)
        {
            if (key == Key.Space)
            {
                playerBulletList.Add(new Bullet(playerTank.bullet_speed, 1, (int)playerTank.PosX + 20, (int)playerTank.PosY + 3));
                usedBullets++;
                Console.SetCursorPosition(15, 8);
                Console.Write("Used bullets: " + usedBullets);
            }
        }
    }
}
