﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEXTRPG;

namespace TEXTRPG
{
    class MainGame
    {
        public Player m_pPlayer = null;
        public Field m_pField = null;



        public void Initialize()
        {
            m_pPlayer = new Player();
            m_pPlayer.SelectJob();

        }

        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                Console.WriteLine("1.사냥터 2.종료 : ");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 2)
                    break;


                if (iInput == 1)
                {

                    if (m_pField == null)
                    {
                        m_pField = new Field();
                        m_pField.SetPlayer(m_pPlayer);
                    }
                    m_pField.Progress();

                }
            }
        }

        public MainGame() { }

        ~MainGame() { }



    }
}
