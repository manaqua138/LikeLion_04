using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _25_02_25_study
{
    class Program
    {
        static void Main(string[] args)
        {
            ////10. for 문

            //for(int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"숫자:{i}");
            //}

            ////11. while 문

            //int count = 0;

            //while (count < 3)
            //{
            //    Console.WriteLine("while문 실행");
            //    count++;

            //}

            //string character = "";
            //int att = 0, def = 0;
            //int select = 0;
            //bool valid = true;

            //Console.WriteLine("캐릭터를 선택하세요. (1. 검사, 2. 마법사, 3. 도적)");
            //select = int.Parse(Console.ReadLine());

            //switch (select)
            //{
            //    case 1:
            //        character = "검사";
            //        att = 100;
            //        def = 90;
            //        break;

            //    case 2:
            //        character = "마법사";
            //        att = 110;
            //        def = 80;
            //        break;

            //    case 3:
            //        character = "도적";
            //        att = 115;
            //        def = 70;
            //        break;

            //    default:
            //        Console.WriteLine("올바른 값을 입력해주십시오.");
            //        valid = false;
            //        break;
            //}

            //if (valid)
            //{
            //    Console.WriteLine($"캐릭터 : {character}");
            //    Console.WriteLine($"공격력 : {att}");
            //    Console.WriteLine($"방어력 : {def}");
            //}

            //1부터 10까지의 합 구하기

            //int sum = 0;

            //for (int i = 0; i <= 10; i++)
            //    sum += i;

            //Console.WriteLine($"1부터 10 까지의 합 = {sum}");

            //13. for 문으로 팩토리얼 값 출력

            //Console.WriteLine("자연수를 입력해 주십시오 : ");
            //int num = int.Parse(Console.ReadLine());
            //int factorial = 1;

            //if (num > 0)
            //{
            //    for (int i = 1; i <= num; i++)
            //    {
            //        factorial *= i;
            //    }

            //    Console.WriteLine($"{num}! = {factorial}");
            //}
            //else
            //    Console.WriteLine("올바른 값을 입력해주십시오.");

            //14. 구구단을 가로로 출력하기

            //for(int i = 1; i <= 9; i ++)
            //{
            //    Console.WriteLine($"----{i}단----");

            //    for(int j = 1; j <= 9; j++)
            //        Console.WriteLine($"{i} * {j} = {i * j}");

            //    Console.WriteLine("");
            //}

            // 0이상 10 미만의 랜덤 정수 생성

            //Random rand = new Random(); //Random 이라는 클래스의 객체를 생성하는 코드

            //for (int i = 0; i < 10; i++)
            //{
            //    int randomNum = rand.Next(0, 10);
            //    Console.WriteLine("0 이상 10 미만의 랜덤 정수 : " + randomNum);
            //}

            //대장장이 키우기

            //Random rand = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    int randnum = rand.Next(100);
            //    string grade = "";

            //    if (randnum < 10)
            //        grade = "SSS";
            //    else if (randnum < 50)
            //        grade = "SS";
            //    else
            //        grade = "S";
            //    Thread.Sleep(500);

            //    Console.WriteLine($"도끼의 등급은 {grade} 입니다!! 축하드립니다!!");
            //}

            // do while 1회 무조건 실행하고 while 문과 같이 조건 진행

            //int x = 5;

            //do
            //{
            //    Console.WriteLine("최소 한번은 실행됩니다.");
            //    x--;
            //} while (x > 0);

            // break, continue, goto 로 반복문 제어

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5)
            //        break;      
            //    Console.WriteLine(i);
            //}

            //for(int i = 1; i<=10; i ++)
            //{
            //    if (i % 2 == 0)
            //        continue;
            //    Console.WriteLine(i);
            //}

            //int n = 1;
            //start:
            //if (n <= 5)
            //{
            //    Console.WriteLine(n);
            //    n++;
            //    goto start;
            //}

            // 대장장이 키우기 구현
            //1. 나무캐기, 2. 장비뽑기, 3. 나가기

            int state = 0;
            int wood = 0;

            do {

                Console.Clear();
                Console.WriteLine("~~~~대장장이 키우기~~~~");
                Console.WriteLine("1.나무캐기\n2.장비뽑기\n3.나가기");

                Thread.Sleep(500);
                state = int.Parse(Console.ReadLine());


                switch (state)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("나무를 캐자!");
                        Console.WriteLine("엔터를 눌러 나무를 획득하자!");
                        Thread.Sleep(500);
                        Console.ReadLine();

                        Random rand = new Random();

                        int get_wood = rand.Next(1,3);

                        Console.WriteLine($"나무를 {get_wood}개 획득했다!");
                        wood += get_wood;

                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("장비를 뽑자!");
                        Console.WriteLine($"현재 가진 나무의 수 : {wood}");
                        Console.WriteLine("뽑을 횟수를 입력해 주세요");

                        int Gacha = int.Parse(Console.ReadLine());

                        if (wood < Gacha)
                        {
                            Console.Clear();
                            Console.WriteLine("나무가 부족합니다!");
                            Console.ReadLine();

                        }
                        else
                        {
                            for (int i = 0; i < Gacha; i++)
                            {
                                Random rand2 = new Random();
                                int randnum = rand2.Next(100);
                                string grade = "";

                                if (randnum < 10)
                                    grade = "S";
                                else if (randnum < 50)
                                    grade = "A";
                                else
                                    grade = "B";
                                Thread.Sleep(500);

                                Console.WriteLine($"도끼의 등급은 {grade} 입니다!! 축하드립니다!!");
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("게임 종료!");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("유효하지 않은 입력입니다.");
                        Console.ReadLine();
                        break;
                }

            } while (state != 3);















        }
    }
}
