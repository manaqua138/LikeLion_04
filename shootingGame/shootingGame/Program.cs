using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame1
{
    class Program
    {
        struct Player // 플레이어 구조체
        {
            public int playerX;
            public int playerY;
            public string[] sharp;
                
        }

        static void Move(ref Player p1) // Move 함수 
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (p1.playerY > 0) p1.playerY--; break;
                    case ConsoleKey.DownArrow: if (p1.playerY < Console.WindowHeight - 1) p1.playerY++; break;
                    case ConsoleKey.LeftArrow: if (p1.playerX > 0) p1.playerX--; break;
                    case ConsoleKey.RightArrow: if (p1.playerX < Console.WindowWidth - 1) p1.playerX++; break;
                    case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                    case ConsoleKey.Escape: Environment.Exit(0); break;
                }
            }
        }


        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            Player p1;

            p1.sharp = new string[]
            {
                "->",
                ">>>",
                "->",
            }; //배열 문자열로 그리기

             p1.playerX = 0;
             p1.playerY = 12;

            Console.CursorVisible = false;

            //시간 1초루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1 /1000    1000일때 1초

            while (true)
            {

                long currentSecond = stopwatch.ElapsedMilliseconds; //현재시간 가져오기

                // Console.WriteLine("1초루프");

                if (currentSecond - prevSecond >= 100)
                {

                    Console.Clear();

                    Move(ref p1);

                    for (int i = 0; i < p1.sharp.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(p1.playerX, p1.playerY + i);
                        //문자열배열 출력
                        Console.WriteLine(p1.sharp[i]);
                    }

                    prevSecond = currentSecond;//이전 시간 업데이트
                }

            }

        }
    }
}