using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfStalingrad
{
    internal class Bullet
    {
        // w zależności od czołgu, każdy pocisk ma swoją szybkość i moc (kaliber)
        public Bullet(double speed, double mass, int posX, int posY)
        {
            this.speed = speed;
            this.mass = mass;
            this.posX = (int)posX;
            this.posY = (int)posY;
        }

        public void Update()
        {
            posX += (double) speed / GameManager.framerate;
            if (speed > 1)   speed -= 30.0 / GameManager.framerate;  // bo powietrze
            if (speed < -1)  speed += 30.0 / GameManager.framerate;  // bo powietrze ale w drugą stronę
            if (posX > 190) speed = 3;  //zabezpiecznie przed wyjściem poza ekran bo GameplayScene usuwa pociski o speed < 10
        }

        public double GetTheObrazenia()  // zwraca ilość szkód, które pocisk wyrządza (na podstawie jego energii kinetycznej czy coś)
        {
            return Math.Abs(mass * speed * speed * 0.0001);
        }

        public double posX, posY, speed, mass;
    }
}
