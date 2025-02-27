using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _25_02_27_study1
{
    class Program
    {
        //static void PrintHello()   //입력, 반환값 없음
        //{
        //    Console.WriteLine("안녕하세요");
        //}

        //static void PrintMessage(string message) //입력 받아 작동
        //{
        //    Console.WriteLine(message);
        //}

        //static int GetNumber() // 입력 없이 반환만
        //{
        //    return 42;
        //}

        //static int Add(int a, int b)  //입력과 반환 
        //{
        //    return a + b;
        //}

        //static void Greet(string name = "손님")  //기본값을 미리 넣어주는 형식 
        //{
        //    Console.WriteLine($"안녕하세요, {name}");
        //}

        //static void Divide(int a, int b, out int quotient, out int remainder)
        //{
        //    quotient = a / b;
        //    remainder = a % b;
        //}

        //static int Sum(params int[] numbers)  //가변 매개변수, params 
        //{
        //    int result = 0;
        //    foreach(int num in numbers)
        //    {
        //        result += num;
        //    }
        //    return result;
        //}

        //static int AddArrow(int a, int b) => a + b;

        //static void PrintMessage()
        //{
        //    Console.WriteLine("안녕하세요");
        //}

        ////화살표 함수
        //static void PrintMessageArrow() => Console.WriteLine("안녕하세요!");


        //기본적인 enum 사용법
        //enum DayOfWeek
        //{
        //    Sunday,   //0
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday
        //}


        ////2.enum  값 변경 (0부터 시작하지않기)
        //enum StatusCode
        //{
        //    Success = 200,
        //    BadRequest = 400,
        //    Unauthorized = 401,
        //    NotFound = 404
        //}

        enum WeaponType
        {
            Sword,
            Bow,
            Staff
        }

        static void ChooseWeapon(WeaponType weapon)
        {
            if (weapon == WeaponType.Sword)
                Console.WriteLine("검을 선택했습니다.");
            else if (weapon == WeaponType.Bow)
                Console.WriteLine("검을 선택했습니다.");
            else if(weapon == WeaponType.Staff)
                Console.WriteLine("검을 선택했습니다.");
            else
                Console.WriteLine("잘못된 선택입니다.");
        }




        static void Main(string[] args)
        {
            //PrintHello();
            //PrintMessage("반갑습니다.");

            //int num = GetNumber();
            //Console.WriteLine(num);

            //int result = Add(3, 5);

            //Greet();
            //Greet("용사님");

            //int q, r;
            //Divide(10, 3, out q, out r);
            //Console.WriteLine($"몫 : {q}, 나머지 : {r}");


            //Console.WriteLine(Sum(1, 2, 3));   //출력 6

            //Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            //C# 화살표 함수 -> 람다 표현식

            //Console.WriteLine(AddArrow(3, 5));
            //PrintMessage();
            //PrintMessageArrow();

            //Console.WriteLine($"Pi : {Math.PI}");
            //Console.WriteLine($"Square root of 25 : {Math.Sqrt(25)}");
            //Console.WriteLine($"Power (2^3) : {Math.Pow(2, 3)}");
            //Console.WriteLine($"Round(3.75) : {Math.Round(3.75)}");

            //DayOfWeek today = DayOfWeek.Wednesday;

            ////숫자를 직접 사용하지 않고, 의미 있는 이름으로 관리 가능
            //Console.WriteLine(today);
            //Console.WriteLine((int)today);

            //StatusCode status = StatusCode.NotFound;
            //Console.WriteLine(status);
            //Console.WriteLine((int)status);

            ChooseWeapon(WeaponType.Sword);
            ChooseWeapon(WeaponType.Bow);
            ChooseWeapon(WeaponType.Staff);

        }
    }
}
