using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _25_02_26_2
{
    class Program
    {
        static void quiz(int num)
        {
            Console.WriteLine($"\n\n-------{num} 번 문제-------\n");
        }

        static int Add(int num1, int num2)
        {
            int result = 0;
            result = num1 + num2;
            return result;
        }

        static int Input_length(string input)
        {
            int result = 0;
            result = input.Length;
            return result;
        }
        
        static int get_max(int[] arr)
        {
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
                if (max < arr[i]) max = arr[i];

            return max;
        }

        static void Main(string[] args)
        {
            quiz(1);

            int[] iArray1 = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < 5; i++)
                Console.Write(iArray1[i] + " ");

            quiz(2);

            int[] iArray2 = new int[5];
            int sum = 0;
            Console.Write("숫자 입력 : ");
            for (int i = 0; i < 5; i++)
            {
                iArray2[i] = int.Parse(Console.ReadLine());
                sum += iArray2[i];
            }
            Console.WriteLine($"총 합: {sum}");

            quiz(3);

            int[] iArray3 = { 3, 8, 15, 6, 2 };
            int max = 0;

            for (int i = 0; i < 5; i++)
                if (max < iArray3[i]) max = iArray3[i];

            Console.WriteLine($"최대값 : {max}");

            quiz(4);

            for (int i = 0; i < 10; i++)
                Console.Write(i + 1 + " ");

            quiz(5);

            int num_5 = 1;
            while (num_5 <= 10)
            {
                if (num_5 % 2 == 0)
                    Console.Write(num_5 + " ");
                num_5++;
            }

            quiz(6);

            int[] iArray6 = { 1, 2, 3, 4, 5 };
            foreach (int num_6 in iArray6)
                Console.Write(num_6 + " ");

            quiz(7);
            Console.WriteLine("3과 5의 합 : " + Add(3, 5));

            quiz(8);
            Console.Write("문자열 입력 : ");
            string Input_8 = Console.ReadLine();
            Console.WriteLine("문자열 길이 : " + Input_length(Input_8));

            quiz(9);

            Console.WriteLine("세 개의 정수 입력 : ");
            int[] iArray9 = new int[3];
            int max_9 = 0;

            for(int i = 0; i < 3; i++)
                iArray9[i] = int.Parse(Console.ReadLine());

            max_9 = get_max(iArray9);
            Console.WriteLine("가장 큰 수 : " + max_9);
           
            














        }
    }
}
