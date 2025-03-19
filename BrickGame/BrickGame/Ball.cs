﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class Ball
    {
        BALLDATA m_tball = new BALLDATA();

        //C# 공의 방향 배열 정의

        int[,] g_WallCollision = new int[4, 6] // 벽면 , 진행방향
        {
            {  3,  2, -1, -1, -1,  4},
            { -1, -1, -1, -1,  2,  1},
            { -1,  5,  4, -1, -1, -1},
            { -1, -1,  1,  0,  5, -1}
        };

        Bar m_pBar;
        public virtual void SetBar(Bar bar) { m_pBar = bar; }
        public BALLDATA GetBall() { return m_tball; }
        public void SetX(int x) { m_tball.nX += x; }
        public void SetY(int y) { m_tball.nY += y; }
        public void SetBall(BALLDATA tball) { m_tball = tball; }
        public void SetReady(int Ready) { m_tball.nReady = Ready; }

        //bar, block 등 구현 필요

        public void ScreenWall()
        {
            Program.gotoxy(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Program.gotoxy(0, 1);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 2);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 3);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 4);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 5);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 6);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 7);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 8);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 9);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 10);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 11);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 12);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 13);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 14);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 15);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 16);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 17);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 18);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 19);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 20);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 21);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 22);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 23);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        }

        public int Collision(int x, int y)
        {
            if( y == 0 )
            {
                m_tball.nDirect = g_WallCollision[0, m_tball.nDirect];
                return 1;// 공의 방향이 바뀌면 1을 리턴
            }

            if( x == 1 )
            {
                m_tball.nDirect = g_WallCollision[1, m_tball.nDirect];
                return 1;
            }

            if (x == 77)
            {
                m_tball.nDirect = g_WallCollision[2, m_tball.nDirect];
                return 1;
            }

            if (y == 23)
            {
                m_tball.nDirect = g_WallCollision[3, m_tball.nDirect];
                return 1;
            }

            //Bar충돌처리
            if (x >= m_pBar.m_tBar.nX[0] && x <= m_pBar.m_tBar.nX[2] + 1 &&
                y == (m_pBar.m_tBar.nY)) //바 위 충돌
            {
                if (m_tball.nDirect == 1)
                    m_tball.nDirect = 2;
                else if (m_tball.nDirect == 2)
                    m_tball.nDirect = 1;
                else if (m_tball.nDirect == 5)
                    m_tball.nDirect = 4;
                else if (m_tball.nDirect == 4)
                    m_tball.nDirect = 5;

                return 1; //방향이 바뀐다.
            }

            if (x >= m_pBar.m_tBar.nX[0] && x <= m_pBar.m_tBar.nX[2] + 1 &&
              y == (m_pBar.m_tBar.nY + 1)) //바 아래 충돌
            {
                if (m_tball.nDirect == 1)
                    m_tball.nDirect = 2;
                else if (m_tball.nDirect == 2)
                    m_tball.nDirect = 1;
                else if (m_tball.nDirect == 5)
                    m_tball.nDirect = 4;
                else if (m_tball.nDirect == 4)
                    m_tball.nDirect = 5;

                return 1; //방향이 바뀐다.
            }



            return 0;
        }


        public void Initialize()
        {
            m_tball.nReady = 0; // 공 안 움직임 1 움직임 0
            m_tball.nDirect = 1;
            m_tball.nX = 30;
            m_tball.nY = 10;

            Console.CursorVisible = false;
        }

        public void Progress()
        {
            if(m_tball.nReady == 0 ) // 0 움직임
            {
                switch(m_tball.nDirect)
                {
                    case 0: // 위
                        if(Collision(m_tball.nX,m_tball.nY - 1) == 0)
                             m_tball.nY--;
                        break;
                    case 1: // 오른쪽 위
                        if (Collision(m_tball.nX + 1, m_tball.nY - 1) == 0)
                        {
                            m_tball.nX++;
                            m_tball.nY--;
                        }
                        break;
                    case 2: // 오른쪽 아래
                        if (Collision(m_tball.nX + 1, m_tball.nY + 1) == 0)
                        {
                            m_tball.nX++;
                            m_tball.nY++;
                        }
                        break;
                    case 3: // 아래
                        if (Collision(m_tball.nX, m_tball.nY + 1) == 0)
                            m_tball.nY++;
                        break;
                    case 4: // 왼쪽 아래
                        if (Collision(m_tball.nX - 1, m_tball.nY + 1) == 0)
                        {
                            m_tball.nX--;
                            m_tball.nY++;
                        }
                        break;
                    case 5: // 왼쪽 위
                        if (Collision(m_tball.nX - 1, m_tball.nY - 1) == 0)
                        {
                            m_tball.nX--;
                            m_tball.nY--;
                        }
                        break;

                }
            }
        }

        public void Render()
        {
            ScreenWall();
            Program.gotoxy(m_tball.nX, m_tball.nY);
            Console.Write("●");
        }

        public void Release() { }












    }
}
