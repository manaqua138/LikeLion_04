using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _25_02_25
{
    class Program
    {
        static void Main(string[] args)
        {
            //모험가 키우기

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;
            Console.Clear();

            DrawBorder();
            Thread.Sleep(1500); 

  

            Random rand = new Random();

            int gold = 1000;
            int health = 50;
            int power = 10;
            int input;
            bool isAlive = true;

            Console.SetCursorPosition(25, 7);
            Console.Write("~~~~~~~~모험가 키우기~~~~~~~~");
            Thread.Sleep(1000);

            while(isAlive)
            {
                ClearInside(17,5);
                Console.Write($" 현재 상태 : 체력 {health} | 골드 {gold} | 공격력 {power}\n");
                Console.SetCursorPosition(17, 7);
                Console.Write("1. 탐험 하기 ");
                Console.SetCursorPosition(17, 9);
                Console.Write("2. 장비 뽑기 (1000골드) ");
                Console.SetCursorPosition(17, 11);
                Console.Write("3. 휴식 하기 (체력 + 20) ");
                Console.SetCursorPosition(17, 13);
                Console.Write("4. 게임 종료 ");
                Console.SetCursorPosition(17, 15);
                input = int.Parse(Console.ReadLine());

                if(input == 1)
                {
                    ClearInside(17, 5);
                    Console.WriteLine(" 탐험을 떠납니다.");
                    Thread.Sleep(500);
                    ClearInside(17, 7);
                    Console.WriteLine(" 탐험을 떠납니다...");
                    Thread.Sleep(500);
                    ClearInside(17, 9);
                    Console.WriteLine(" 탐험을 떠납니다.....");
                    Thread.Sleep(500);
                    ClearInside(17, 11);
                    Console.WriteLine(" 탐험을 떠납니다.......");
                    Thread.Sleep(500);

                    ClearInside(17, 13);
                    int eventChance = rand.Next(1, 101);

                    if (eventChance <= 20)
                    {
                        int damage = rand.Next(60, 150);
                        int kill_bos = power * damage;
                        Console.Write($" 보스 몬스터를 만났습니다!");
                        Thread.Sleep(1000);


                        if (kill_bos > 10500)
                        {
                            int reward_boss = rand.Next(7000, 20000);
                            Console.SetCursorPosition(17, 15);
                            Console.Write($" 보스 몬스터를 처치하였습니다! (+{reward_boss} 골드)");
                            gold += reward_boss;
                            Thread.Sleep(1500);
                        }
                        else
                        {
                            Console.SetCursorPosition(17, 15);
                            Console.Write($" 보스 몬스터로부터 간신히 도망쳤습니다... (체력 -{damage})");
                            health -= damage;
                            Thread.Sleep(1000);
                        }
                        
                    }
                    else if (eventChance <= 40)
                    {
                        int damage = rand.Next(5, 21);
                        int kill_mob = power * damage;
                        Console.WriteLine($" 몬스터를 만났습니다!");
                        Thread.Sleep(1000);


                        if (kill_mob > 250)
                        {
                            int reward_mob = rand.Next(500, 1500);
                            Console.SetCursorPosition(17, 15);
                            Console.WriteLine($" 몬스터를 처치하였습니다! (+{reward_mob} 골드)");
                            gold += reward_mob;
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.SetCursorPosition(17, 15);
                            Console.WriteLine($" 몬스터로부터 간신히 도망쳤습니다... (체력 -{damage})");
                            health -= damage;
                            Thread.Sleep(1000);
                        }
                        
                    }
                    else if (eventChance <= 80)
                    {
                        int reward = rand.Next(100, 500);
                        Console.WriteLine($" 보물을 발견했습니다! (+{reward} 골드)");
                        gold += reward;
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        int heal = rand.Next(10, 31);
                        Console.WriteLine($" 신비한 약초를 발견했습니다! (+{heal} 체력)");
                        health += heal;
                        Thread.Sleep(1000);
                    }

                    if(health <= 0)
                    {
                        ClearInside(17, 15);
                        Console.WriteLine(" 체력이 0이 되어 사망했습니다.");
                        isAlive = false;
                        Thread.Sleep(2000);
                        Console.Clear();
                    } 
                }
                else if (input == 2)
                {
                    if(gold >= 1000)
                    {
                        gold -= 1000;
                        ClearInside(17, 5);
                        Console.Write("장비를 뽑습니다...");
                        Thread.Sleep(1000);

                        int rnd = rand.Next(1,101);

                        if(rnd == 5)
                        {
                            Console.SetCursorPosition(17, 7);
                            Console.WriteLine("SSS급 전설의 검 (공격력 + 50) 획득!!!!!");
                            power += 50;
                            Thread.Sleep(1000);
                        }
                        else if (rnd <= 20)
                        {
                            Console.SetCursorPosition(17, 7);
                            Console.WriteLine("SS급  영웅의 검 (공격력 + 30) 획득!!!");
                            power += 30;
                            Thread.Sleep(1000);
                        }
                        else if (rnd <= 70)
                        {
                            Console.SetCursorPosition(17, 7);
                            Console.WriteLine("S급 강철 검 (공격력 + 10) 획득!");
                            power += 10;
                            Thread.Sleep(1000);
                        }
                        else 
                        {
                            Console.SetCursorPosition(17, 7);
                            Console.WriteLine("A급 녹슨 칼 (공격력 + 5) 획득");
                            power += 5;
                            Thread.Sleep(1000);
                        }
                    }
                    else 
                    {
                        ClearInside(17, 5);
                        Console.WriteLine("골드가 부족합니다....");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)
                {
                    ClearInside(17, 5);
                    Console.WriteLine(" 휴식을 취합니다.... (체력 + 20)");
                    health += 20;
                    Thread.Sleep(1000);
                }
                else if (input == 4)
                {
                    isAlive = false;
                }
                else
                {
                    ClearInside(17, 5);
                    Console.Write("올바른 값을 입력해주세요");
                    Thread.Sleep(1000);
                }

            }

            void DrawBorder() // 기본 테두리를 그리는 함수
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┒");

                for (int i = 1; i < 20; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("┃                                                                            ┃");
                }
                Console.SetCursorPosition(0, 20);
                Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            }

            void ClearInside(int x,int y)
            {
               for (int i = 1; i < 20; i++)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write(new string(' ', 76));
                }

                Console.SetCursorPosition(x, y);

            }




        }
    }
}
