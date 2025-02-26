using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _25_02_26
{
    class Program
    {
        static void Main(string[] args)
        {
            // 배열

            //int[] num = new int[3]; // 3개 공간 , new -> 메모리를 생성하라

            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;

            //Console.WriteLine(num[0]);
            //Console.WriteLine(num[1]);
            //Console.WriteLine(num[2]);

            //for (int i = 0; i < 3; i++) // 배열은 for 문과 자주 사용된다.
            //    Console.WriteLine(num[i]);
            //int[] numbers = { 1, 2, 3 };
            //int[] numbers2 = new int[3];
            //int[] numbers3 = new int[] { 1, 2 ,3};

            //string[] fruits = { "사과", "바나나", "오렌지" };

            //for(int i = 0; i < 3; i ++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            // 3명의 국어,영어 수학 점수를 입력받고 총점과 평균을 출력

            //int[,] matrix = new int[3, 3];

            //for (int i =0; i < 3; i++)
            //{
            //    Console.WriteLine($"{i + 1}번째 학생의 국어, 영어, 수학 점수를 차례로 입력해주세요.");
            //    for (int j = 0; j < 3; j++)
            //    {
            //
            //        matrix[i, j] = int.Parse(Console.ReadLine());
            //        if (j == 0)
            //            Console.WriteLine("국어 점수 입력 완료!");
            //        else if (j == 1)
            //            Console.WriteLine("영어 점수 입력 완료!");
            //        else
            //            Console.WriteLine("수학 점수 입력 완료!");
            //    }

            //}

            //for (int k = 0; k < 3; k++)
            //{
            //    int total = matrix[k, 0] + matrix[k, 1] + matrix[k, 2];
            //    Console.WriteLine($"{k + 1}번째 학생의 총점은 {total}, 평균은 {((float)total / 3).ToString("F2") } 입니다.");
            //}

            //소수점 포멧

            //double value = 123.456789;

            //Console.WriteLine(value.ToString("F2"));
            //Console.WriteLine($"소수점 둘째 자리 : {value:F2}");
            //Console.WriteLine(String.Format("소수점 둘째 자리 : {0:F2}",value));

            //가변 배열

            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[] { 1, 2 };
            //jaggedArray[1] = new int[] { 3, 4, 5 };
            //jaggedArray[2] = new int[] { 6 };

            //for(int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for(int j = 0; j < jaggedArray[i].Length;j++ )
            //    {
            //        Console.Write($"{jaggedArray[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}

            // var 키워드 사용

            //Console.WriteLine("var 키워드 사용");
            //var numbers = new[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"배열 타입 : {numbers.GetType()}");

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"number {i} : {numbers[i]}");
            //}

            //object[] mixedArray = { 42, "사과", 'A', 3.14, false }; //object 를 이용하여 다양하게 저장가능

            //for (int j = 0; j < 5; j++)
            //{
            //    Console.WriteLine($"number {j} : {mixedArray[j]}");
            //    Console.WriteLine($"배열 타입 : {mixedArray[j].GetType()}");
            //}

            ////swap
            //int a = 10;
            //int b = 20;
            //int temp = 0;

            //temp = a;
            //a = b;
            //b = temp;

            //Console.WriteLine($"a : {a}, b : {b}");

            // 빙고 만들기

            //int[] iArray = new int[25];

            //for(int i = 0; i<25; i++)
            //{
            //    iArray[i] = i + 1;
            //}

            //for(int j = 0; j <5; j++)
            //{
            //    for(int k = 0; k < 5; k++)
            //    {
            //        Console.Write(iArray[5*j+k].ToString("D2") + " "); //D5 -> 5자리 고정 빈공간은 0
            //    }
            //    Console.WriteLine();
            //}

            //Random rand = new Random();

            //for(int i = 0; i< 100; i++)
            //{
            //    int iA = rand.Next(0,25);
            //    int iB = rand.Next(0,25);
            //    int iT = 0;

            //    iT = iArray[iA];
            //    iArray[iA] = iArray[iB];
            //    iArray[iB] = iT;

            //}

            //Console.WriteLine("------------shuffle----------");

            //while (true)

            //{
            //    int input = 0;
            //    int bingo = 0;


            //    for (int j = 0; j < 5; j++)
            //    {
            //        for (int k = 0; k < 5; k++)
            //        {
            //            if (iArray[5 * j + k] == 0)
            //            {
            //                Console.Write(" * ");
            //            }
            //            else
            //            {
            //                Console.Write(iArray[5 * j + k].ToString("D2") + " "); //D5 -> 5자리 고정 빈공간은 0
            //            }
            //        }
            //        Console.WriteLine();
            //    }

            //    Console.WriteLine("숫자를 입력하세요 : ");
            //    input = int.Parse(Console.ReadLine());



            //    if (input > 0 && input <= 25)
            //    {
            //        for (int l = 0; l < 25; l++)
            //        {
            //            if (iArray[l] == input)
            //                iArray[l] = 0;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("올바른 수를 입력해주세요");
            //        Thread.Sleep(1000);
            //    }


            //    for(int m = 0; m < 5; m++)
            //    {
            //        int sum = 0;

            //        for (int n = 0; n < 5; n++)  //가로 체크
            //        {
            //            sum += iArray[m * 5 + n];
            //        }
            //        if (sum == 0)
            //            bingo++;

            //        sum = 0;

            //        for(int o = 0; o < 5; o++)  //세로 체크
            //        {
            //            sum += iArray[o * 5 + m];
            //        }
            //        if (sum == 0)
            //            bingo++;

            //    }

            //    int diagonal1 = 0;
            //    int diagonal2 = 0;

            //    diagonal1 = iArray[0] + iArray[6] + iArray[12] + iArray[18] + iArray[24];
            //    diagonal2 = iArray[4] + iArray[8] + iArray[12] + iArray[16] + iArray[20];

            //    if (diagonal1 == 0)
            //        bingo++;
            //    if (diagonal2 == 0)
            //        bingo++;

            //    Console.WriteLine($"현재 빙고 수 : {bingo}"); // 


            //}

            int[,] board = new int[5, 5]; //5x5 빙고판
            bool[,] marked = new bool[5, 5]; //선택된 숫자 체크

            int bingoCount = 0;

            Random random = new Random();

            //빙고판 초기화
            int[] numbers = new int[25];

            for (int i = 0; i < 25; i++)
                numbers[i] = i + 1;

            //랜덤 섞기(Fisher-Yates Shuffle)
            for (int i = 0; i < 100; i++)
            {
                int a = random.Next(25);
                int b = random.Next(25);

                // C#의 튜플(Tuple) 문법을 활용하여 두 변수의 값을 교환(Swap)하는 방법
                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);

            }


            //2차원 배열로 변환
            //1차원으로 요소들을 넣고 교환을 통해 랜덤으로 섞은 후 이차원 재배열

            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    board[i, j] = numbers[index++];
                }
            }

            //게임시작
            while (bingoCount < 5)
            {
                Console.Clear();

                //빙고판 출력
                Console.WriteLine("현재 빙고판");


                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (marked[i, j])
                            Console.Write(" X ");
                        else
                            Console.Write($"{board[i, j],2} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수 : {bingoCount}");
                Console.Write("숫자를 입력하세요 (1~25) : ");
                int number = int.Parse(Console.ReadLine());

                bool found = false;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (board[i, j] == number)
                        {
                            marked[i, j] = true; //숫자를 X로 변경
                            found = true;
                            break;
                        }
                    }
                    if (found)
                        break;
                }

                //빙고 개수 체크
                bingoCount = 0;

                //가로체크
                for (int i = 0; i < 5; i++)
                {
                    bool rowBingo = true;
                    for (int j = 0; j < 5; j++)
                        if (!marked[i, j]) rowBingo = false;

                    if (rowBingo) bingoCount++;
                }


                //세로체크
                for (int j = 0; j < 5; j++)
                {
                    bool colBingo = true;

                    for (int i = 0; i < 5; i++)
                        if (!marked[i, j]) colBingo = false;

                    if (colBingo) bingoCount++;
                }


                //대각선 체크 (왼쪽위 ->오른쪽 아래)

                bool diag1Bingo = true;

                for (int i = 0; i < 5; i++)
                {
                    if (!marked[i, i])
                        diag1Bingo = false;
                }
                if (diag1Bingo)
                    bingoCount++;


                //대각선 오른쪽위 ->왼쪽아래
                bool diag2Bingo = true;

                for (int i = 0; i < 5; i++)
                    if (!marked[i, 4 - i]) diag2Bingo = false;


                if (diag2Bingo) bingoCount++;

            }

            Console.WriteLine("빙고 5개 완성! 게임종료");


        }
    }
}
