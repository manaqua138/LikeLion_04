using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    class Block
    {
        List<BlockData> m_tblocks = new List<BlockData>(30);


        public void Initialize()
        {
            Random rand = new Random();


            for (int i = 0; i < 10; i++)
            {
                int rand_x = rand.Next(2, 73);
                int rand_y = rand.Next(1, 15);
                m_tblocks.Add(new BlockData(rand_x, rand_y, true)); // 초기값 추가
                m_tblocks.Add(new BlockData(rand_x + 2, rand_y, true)); // 초기값 추가
                m_tblocks.Add(new BlockData(rand_x + 4, rand_y, true)); // 초기값 추가
            }
        }

        public void Render()
        {
            bool anyAlive = m_tblocks.Any(m_tblocks => m_tblocks.isAlive);
           
            if (anyAlive)
            {
                for (int i = 0; i < 30; i += 3)
                {
                    if (m_tblocks[i].isAlive == true)
                    {
                        Program.gotoxy(m_tblocks[i].nX, m_tblocks[i].nY);
                        Console.Write("■■■");
                    }
                }
            }
            else
            {
                Initialize();
            }
            
        }

        public void Progress(ref Ball pBall)
        {



        }



        public void Release()
        {
        }





    }
}
