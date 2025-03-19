using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class BlockData
    {
        public int nX;
        public int nY;
        public bool isAlive = false;

        public BlockData(int x, int y, bool alive = false)
        {
            nX = x;
            nY = y;
            isAlive = alive;
        }


    }
}
