using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace MyGame
{
    internal class Zombie : GameObject
    {

        public Zombie(int initialX, int initialY)
        {
            x = initialX;
            y = initialY;
            speed= 1.0f;
        }
        public void zomb_move()
        {
            y -= 1; 
        }
        public void zomb_render()
        {

        }

    }
}
