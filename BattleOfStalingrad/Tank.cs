using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfStalingrad
{
    internal class Tank
    {
        public int newLevel = 0;
        public Tank(int level)  // tworzenie czołgu na podstawie jego poziomu
        {
            if (level < 0) level = 0;
            if (level > 10) level = 9;
            level *= 5;
            level += 50;
            var rand = new Random();
            while (newLevel <= level || newLevel >= level + 9)
            {
                speed =             rand.Next(10, 20);                                  // ciekawe
                reload_rate =       rand.Next(10, 20);                                  // rozwiązania
                bullet_strength =   rand.Next(10, 20);                                  // programistyczne
                bullet_speed =      rand.Next(10, 20);                                  // aka 
                newLevel = speed + reload_rate + bullet_strength + 2 * bullet_speed;    // patoprogramowanie
            }

            PosX = 150;
            PosY = rand.Next(10, 40);
        }

        public Tank(int speed, int hp, int reload_rate, int bullet_strength, int bullet_speed)  // tworzenie czołgu na podstawie jego parametrów
        {
            this.speed =            speed;
            this.hp =               hp;
            this.reload_rate =      reload_rate;
            this.bullet_strength =  bullet_strength;
            this.bullet_speed =     bullet_speed;
            PosX = 10;
            PosY = 20;
        }

        public int speed, hp, reload_rate, bullet_strength, bullet_speed;

        private double reload_phase = 0.0;

        private double posX, posY;
        public double PosX
        {
            get { return posX; }
            set { if (value >= 5 && value <= 174) posX = value; }
        }
        public double PosY
        {
            get { return posY; }
            set { if (value >= 10 && value <= 40) posY = value; }
        }
        public enum direction {up, down, right, left }
        public void Move(direction dir)
        {
            switch (dir)
            {
                case direction.up:      PosY -= 0.75 * speed / GameManager.framerate; break; // takie taby bo tak ładnie wygląda
                case direction.down:    PosY += 0.75 * speed / GameManager.framerate; break;
                case direction.right:   PosX += 0.50 * speed / GameManager.framerate; break;
                case direction.left:    PosX -= 0.50 * speed / GameManager.framerate; break;
            }
        }

        public int Reload()
        {
            reload_phase += 0.025 * reload_rate / GameManager.framerate;  // zwiększenie fazy ładowania

            if (reload_phase < 0.1) return 1;  // przygotowanie do dalszej jazdy

            if (reload_phase < 0.5) return 0;  // trwa ładowanie, można jechać

            if (reload_phase < 1.0) return 1; // ładowanie zakończone, teraz trzeba się zatrzymać żeby oddać strzał

            reload_phase -= 1.0;  // oddanie strzału
            return 2;
        }
    }
}
