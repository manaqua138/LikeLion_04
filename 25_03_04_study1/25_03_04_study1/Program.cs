using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _25_03_04_study1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("프로그램 종료");
            //string path = Environment.GetEnvironmentVariable("PATH");
            //Console.WriteLine($"PATH: {path}");

            //Environment.Exit(0);

            //Random random = new Random();

            //int randomNumber = random.Next(1, 101); // 1부터 100까지
            //Console.WriteLine("랜덤 숫자 : " + randomNumber);

            ////프로그램 실행 시간 구하기

            //Stopwatch stopwatch = Stopwatch.StartNew();
            //double sum = 0;

            //for(int i = 0; i < 10000000; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine("sum : " + sum);
            //stopwatch.Stop();

            //Console.WriteLine("for 문 시간 : " + stopwatch.ElapsedMilliseconds);

            string input = "Hello, my phone number is 010-1234-5678.";
            string pattern = @"\d{3}-\d{4}-\d{4}";

            bool isMatch = Regex.IsMatch(input, pattern);
            Console.WriteLine($"전화번호가 존재하는가? {isMatch}");

             //클래스시그니처 기본구성
             //C#에서 클래스 시그니처는 클래스의 선언부를 의미한다.

            //[접근 지정자] [수정자] class 클래스이름  : 부모클래스 , 인터페이스
            //public       abstract                  : BaseClass  ,IComparable
            //private      sealed
            //protected    static
            //             partial

            //기본클래스
 public class Player
        {
            public string Name { get; set; }
            public int Score { get; set; }
        }
        //상속하는 클래스
        public class Warrior : Player
        {
            public int Strength { get; set; }
        }
        //인터페이스를 구현하는 클래스
        //public class Enemy: IAttackable, IMovable
        //{
        //    public void Attack() { }
        //    public void Move() { }

        //}
        //추상 클래스 (abstract)
        public abstract class Animal
        {
            public abstract void MakeSound();
        }


    }
    }
}
