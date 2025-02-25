using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_25_콘솔좌표배우기
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;
            Console.Clear();

            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┒");

            for (int i = 1; i < 20; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("┃                                                                              ┃");
            }
            Console.SetCursorPosition(0, 20);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Thread.Sleep(5000);

            Console.Clear();

            for(int x = 0; x <80; x++)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 10);
                Console.Write("◎");
                Thread.Sleep(50);
            }



        }
    }
}
