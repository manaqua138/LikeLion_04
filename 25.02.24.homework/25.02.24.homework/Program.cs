using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _25._02._24.homework
{
    class Program
    {
        static void Main(string[] args)
        {
            ////문제 1. 학점 평균 계산 프로그램

            //Console.WriteLine("문제 1.\n");
            //Console.WriteLine("국어 점수를 입력하세요 : ");
            //int iKor = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("영어 점수를 입력하세요 : ");
            //int iEng = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("수학 점수를 입력하세요 : ");
            //int iMath = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;
            //float average = 0.0f;

            //sum = iKor + iEng + iMath;

            //average = sum / 3.0f;

            //Console.WriteLine($"총점 : {sum}");
            //Console.WriteLine($"평균 : {average:F2}");

            ////문제 2. 비트 반전(~) 연산자 활용 프로그램

            //Console.WriteLine("\n문제 2.\n");
            //Console.WriteLine("정수를 입력하세요 : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //int result = ~num;

            //Console.WriteLine($"원래의 값 : {num}");
            //Console.WriteLine($"비트 반전 후의 값 : {result}");

            ////문제 3. 삼항연산자

            //Console.WriteLine("\n문제 3.\n");

            //int key = Convert.ToInt32(Console.ReadLine());
            //string str = (key == 1) ? "문이 열렸습니다." : "문이 잠겼습니다.";

            //Console.WriteLine(str);

            //문제 4. if else

            //Console.WriteLine("소지금을 입력해주세요 : ");

            //int money = int.Parse(Console.ReadLine());
            //int add_att = 0;
            //string weapon = "기본무기";

            //    if (money > 600)
            //    {
            //        weapon = "전설의검";
            //        add_att = 7;
            //    }
            //    else if (money > 500)
            //    {
            //        weapon = "유령검";
            //        add_att = 6;
            //    }
            //    else if (money > 400)
            //    {
            //        weapon = "엑스칼리버";
            //        add_att = 5;
            //    }
            //    else if (money > 300)
            //    {
            //        weapon = "집판검";
            //        add_att = 4;
            //    }
            //    else if (money > 200)
            //    {
            //        weapon = "진은검";
            //        add_att = 3;
            //    }
            //    else if (money > 100)
            //    {
            //        weapon = "카타나";
            //        add_att = 2;
            //    }
            //    else
            //    {
            //        weapon = "무한의대검";
            //        add_att = 1;
            //    }

            //Console.WriteLine("캐릭터 : 멋사검존");
            //Console.WriteLine("무기 : " + weapon);
            //Console.WriteLine("공격력 : 100 + " + add_att);


            //02_24 오후 문제 

            //문제 1. 세 정수의 최대값 구하기
            Console.WriteLine("\n문제 1.\n");
            Console.WriteLine("세 정수를 입력하세요 : ");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);

            Console.WriteLine($"최대값 : {max}");

            //문제 2. 점수에 따른 학점 평가

            Console.WriteLine("\n문제 2.\n");
            Console.WriteLine("점수를 입력해주세요 : ");

            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
                Console.WriteLine("A학점");
            else if (score >= 80)
                Console.WriteLine("B학점");
            else if (score >= 70)
                Console.WriteLine("C학점");
            else if (score >= 60)
                Console.WriteLine("D학점");
            else
                Console.WriteLine("F학점");

            //문제 3. 간단한 사칙연산 계산기

            Console.WriteLine("\n문제 3.\n");
            Console.WriteLine("두 정수를 입력하세요 : ");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("연산자를 입력하세요 : ");
            string op = Console.ReadLine();

            if (op == "+")
                Console.WriteLine($"결과 : {num1 + num2}");
            else if (op == "-")
                Console.WriteLine($"결과 : {num1 - num2}");
            else if (op == "*")
                Console.WriteLine($"결과 : {num1 * num2}");
            else if (op == "/")
            {
                if (num2 == 0)
                    Console.WriteLine("0이 아닌 다른 수를 입력하십시오");
                else
                    Console.WriteLine($"결과 : {((float)num1 / num2):F2}");
            }
            else
                Console.WriteLine("잘못된 연산자를 입력하셨습니다.");
            






        }
    }
}
