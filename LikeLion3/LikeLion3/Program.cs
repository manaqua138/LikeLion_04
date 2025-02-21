using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. 변수 선언과 동시에 초기화하기

            //string greeting;
            //greeting = "Hello, World!";

            //Console.WriteLine(greeting);

            //int score = 100;
            //double temperature = 36.5;
            //string city = "Seoul";

            //Console.WriteLine(score);
            //Console.WriteLine(temperature);
            //Console.WriteLine(city);


            //5. 형식이 같은 변수 여러 개를 한 번에 선언하기

            //int x = 10, y = 20, z = 30;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //6. 상수 사용하기

            //const double Pi = 3.14159;
            //const int MaxScore = 100;

            //Console.WriteLine("Pi : " + Pi);
            //Console.WriteLine("Max Score : " + MaxScore);


            //7. 로스트아크 캐릭터 출력

            //int Att = 16755, Hp = 78103;
            //int Crit = 36, Specialization = 1017, Domination = 41, Swiftness = 611, Endurance = 22, Expertise = 39;

            //Console.WriteLine("-------기본특성------");
            //Console.WriteLine("공격력 : " + Att);
            //Console.WriteLine("최대 생명력 : " + Hp);
            //Console.WriteLine("-------전투특성------");
            //Console.WriteLine("치명 : " + Crit);
            //Console.WriteLine("특화 : " + Specialization);
            //Console.WriteLine("제압 : " + Domination);
            //Console.WriteLine("신속 : " + Swiftness);
            //Console.WriteLine("인내 : " + Endurance);
            //Console.WriteLine("숙련 : " + Expertise);

            //1. 숫자 데이터 형식

            //int integerNum = 10;
            //float floatNum = 3.14f;
            //double doubleNum = 3.14159;

            //Console.WriteLine(integerNum);
            //Console.WriteLine(floatNum);
            //Console.WriteLine(doubleNum);

            //2. 정수 데이터 형식

            //int intValue = -100;
            //long longValue = 1234567890L;

            //Console.WriteLine(intValue);
            //Console.WriteLine(longValue);

            //3. 부호 있는 정수 데이터 형식

            //sbyte signedByte = -50;
            //short signedShort = -32000;
            //int signedInt = -2000000000;

            //Console.WriteLine(signedByte);
            //Console.WriteLine(signedShort);
            //Console.WriteLine(signedInt);

            ////4. 부호 없는 정수 데이터 형식

            //byte unsignedByte = 255;
            //ushort unsignedShort = 65000;
            //uint unsignedInt = 4000000000;

            //Console.WriteLine(unsignedByte);
            //Console.WriteLine(unsignedShort);
            //Console.WriteLine(unsignedInt);

            //5. 실수 데이터 형식

            //float singlePrecision = 3.14f;
            //double doublePrecision = 3.1415926535;
            //decimal highPrecision = 3.1415926535897932384626433833m; //고정밀도 금융 계산에 사용

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);

            //6. 숫자 형식의 리터럴 값에 접미사 붙이기

            //int integerValue = 100;
            //long longValue = 100L;
            //float floatValue = 3.14f;
            //double doubleValue = 3.14;
            //decimal decimalValue = 3.14m;

            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);

            // 1. 문자 데이터 형식

            //char letter = 'A';
            //char symbol = '#';
            //char number = '9';

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);

            ////2. 문자열 데이터 형식

            //string greeting = "Hello, World!";
            //string name = "Alice";

            //Console.WriteLine(greeting);
            //Console.WriteLine(name);

            //Console.WriteLine(greeting + " " +name);

            ////3. 논리 데이터 형식 

            //bool isRunning = true;
            //bool isFinished = false;

            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);

            ////4. 변하지 않는 값

            //const double Pi = 3.14159;
            //const int MaxScore = 100;

            //Console.WriteLine(Pi);
            //Console.WriteLine(MaxScore);

            //5. 닷넷 데이터 형식

            //System.Int32 number = 123;
            //System.String text = "Hello";
            //System.Boolean flag = true;

            //Console.WriteLine(number);
            //Console.WriteLine(text);
            //Console.WriteLine(flag);

            //6. 래퍼 형식

            int number = 123;
            string numberAsString = number.ToString(); //정수를 문자열로 변환

            bool flag = true;
            string flagAsString = flag.ToString(); //논리값을 문자열로 변환

            Console.WriteLine(numberAsString);
            Console.WriteLine(flagAsString);


        }
    }
}
