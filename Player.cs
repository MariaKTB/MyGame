using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class Player : GameObject
    {
        public Player(int initialX, int initialY)
        {
            x = initialX;
            y = initialY;
            speed = 1.0f; 
        }

        public void char_move(int dx)
        {
            x += dx;
            y = 0;
            speed = 1.0f;

            if (dx > 800) { x = 0; }
            if (dx < 0) { x = 800; }
        }
        
        public void shootBullet()
        {

        }
        public string GetPosition()
        {
            return $"Player's position: ({x}, {y})";
        }
    }
}
