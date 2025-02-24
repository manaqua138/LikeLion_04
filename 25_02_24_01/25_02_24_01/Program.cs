using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_02_24_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 이진수 다루기

            //Console.Write("2진수를 입력하세요 : ");
            //string binaryinput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryinput, 2);
            //string Output = Convert.ToString(decimalValue, 16);

            //Console.WriteLine($"입력한 이진수 : {binaryinput}");
            //Console.WriteLine($"10진수로 변환 : {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환 : {Output}");

            //// 8은 가능한데 4는 안됨 .NET 에서는 2, 8,10,16 이외의 진법을 지원하지 않는다.
            //// 한 번 n 진법 함수를 만들어 보자

            //2. var키워드로 암시적으로 형식화된 로켤 변수 만들기

            //var name = "Alice";
            //var age = 25;
            //var isStudent = true;

            //Console.WriteLine($"이름 : {name}, 나이 {age}, 학생 여부 : {isStudent}");

            //상당히 간편하네 근데 막 쓰면 오류가 많이 발생할 것 같음

            //3. 변수의 기본값을 default 키워드로 설정하기

            //int defaultInt = default;
            //string defaultString = default;
            //bool defaultBool = default;

            //Console.WriteLine($"정수 기본값 : {defaultInt}");
            //Console.WriteLine($"문자열 기본값 : {defaultString}");
            //Console.WriteLine($"논리값 기본값 : {defaultBool}");

            //1. 연산자

            //int a = 5, b = 3;
            //int sum = a + b;
            //int del = a - b;
            //int mul = a * b;
            //float div = a / (float)b;
            //bool isEqual = (a == b);

            //Console.WriteLine($"더하기 : {sum}");
            //Console.WriteLine($"빼기 : {del}");
            //Console.WriteLine($"곱하기 : {mul}");
            //Console.WriteLine($"나누기 : {div}");
            //Console.WriteLine($"a와 b가 같은가? {isEqual}");

            //2. 단항 연산자

            //int number = 5;
            //Console.WriteLine(+number);
            //Console.WriteLine(-number);

            //bool flag = true;
            //Console.WriteLine(!flag);

            //~ 비트 반전

            //int num = 10;
            //int result = ~ num;

            //Console.WriteLine($"원래 값 : {num}");
            //Console.WriteLine($"~연산자 적용 후 : {result}");

            // 보수라는 것은 비트를 반전하고 1을 더해야 함 ~X = -(X+1)

            //3.변환 연산자 (캐스팅)

            //double pi = 3.14;
            //int integerPi = (int)pi;

            //Console.WriteLine(integerPi);

            //int iKor = 90;
            //int iEng = 75;
            //int iMath = 58;

            //int sum = 0;
            //float average = 0.0f;

            //sum = iKor + iEng + iMath;

            //average = sum / 3.0f ;

            //Console.WriteLine($"총점 : {sum}");
            //Console.WriteLine($"평균 : {average}");

            // 평균을 구할때 두 수 중 한개는 float를 해야 잘 계산되어 나온다.

            //4. 산술 연산자

            //int a = 10, b = 3;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //5. 문자열 연결 연산자

            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + " " + lastName);

            ////6. 할당 연산자

            //int a = 10;
            //a += 5;
            //Console.WriteLine(a);

            ////7. 증감 연산자

            //int b = 3;
            //b++;
            //Console.WriteLine(b);
            //--b;
            //Console.WriteLine(b);

            // 전위 연산자 와 후위 연산자 차이 : 전위는 라인에서 먼저 적용후 그 라인 실행, 후위는 라인 실행 후 다음 라인 부터 적용

            ////8. 관계형 연산자

            //int x = 5, y = 10;
            //Console.WriteLine(x < y);
            //Console.WriteLine(x == y);

            ////9. 논리 연산자

            //bool a = true, b = false;
            //Console.WriteLine(a && b);
            //Console.WriteLine(a || b);
            //Console.WriteLine(!a);

            //10. 비트 연산자

            //int x = 5; // 0101
            //int y = 3; // 0011

            //Console.WriteLine(x & y);  // 0001 이므로 1 AND
            //Console.WriteLine(x | y);  // 0111 이므로 7 OR
            //Console.WriteLine(x ^ y);  // 0110 이므로 6 XOR
            //Console.WriteLine(~x);     // x는 32비트 int 이므로 0000 0000 ..... 0101  ~x = 1111 1111 .... 1010 , 2진수 보수 방법으로 ~x = -(x+1) = -6

            //11. 시프트 연산자

            //int value = 4;
            //Console.WriteLine(value << 1);   // 왼쪽이동은 2진수에서 2곱하기 2
            //Console.WriteLine(value >> 1);   // 오른쪽 이동은 나누기 2

            ////12. 기타 연산자

            //int a = 10, b = 20;
            //int max = (a > b) ? a : b;   // (조건) ? true : false // 삼항 연산자
            //Console.WriteLine(max);

            //13. 연산자 우선순위

            //int result = 10 + 2 * 5;
            //Console.WriteLine(result);

            //int adjustedResult = (10 + 2) * 5;
            //Console.WriteLine(adjustedResult);

            //제어문
            //1. if 문

            //Console.WriteLine("점수를 입력해주세요 : ");

            //int score = int.Parse(Console.ReadLine());

            //if (score >= 90)
            //    Console.WriteLine("A학점");
            //else if (score >= 80)
            //    Console.WriteLine("B학점");
            //else if (score >= 70)
            //    Console.WriteLine("C학점");
            //else
            //    Console.WriteLine("F학점");

            ////2. switch 문

            //int day = 3;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    default:
            //        Console.WriteLine("유효하지 않은 요일");
            //        break;
            //}





















        }
    }
}