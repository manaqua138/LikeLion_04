using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_03_04_assignment
{
    //class Warrior
    //{
    //    public string Name;
    //    public int Score;
    //    public int Strength; 
    //}


    class Program
    {
        static void Main(string[] args)
        {
            //과제 1

            //Warrior char1 = new Warrior();

            //char1.Name = "Kazan";
            //char1.Score = 97;
            //char1.Strength = 42;

            //Console.WriteLine($"Name : {char1.Name}, Score : {char1.Score}, Strength : {char1.Strength}");

            //과제 2

            //Console.WriteLine("정수를 입력하세요 : ");
            //try
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"입력한 정수는 {number} 입니다.");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("올바른 숫자를 입력하세요!");
            //}

            //과제 3

            //List<string> fruits= new List<string>();

            //fruits.Add("사과");
            //fruits.Add("바나나");
            //fruits.Add("포도");

            //foreach(var fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}


            //Queue<string> queue = new Queue<string>();

            //queue.Enqueue("첫 번째 작업");
            //queue.Enqueue("두 번째 작업");
            //queue.Enqueue("세 번째 작업");

            //while (queue.Count > 0)
            //    Console.WriteLine(queue.Dequeue());

            //Stack<int> score = new Stack<int>();
            //score.Push(1);
            //score.Push(2);
            //score.Push(3);

            //while (score.Count > 0)
            //    Console.WriteLine(score.Pop());

            //과제 4

            //string Input = Console.ReadLine();
            //string UpperInput = Input.ToUpper();
            //string ReplaceInput = Input.Replace("C#", "CSharp");
            //int InputLength = Input.Length;

            //Console.WriteLine("Input : " + Input);
            //Console.WriteLine("UpperInput : " + UpperInput);
            //Console.WriteLine("ReplaceInput : " + ReplaceInput);
            //Console.WriteLine("InputLength : " + InputLength);

            //과제 5

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numQuery = from num in numbers
                           where (num % 2) == 0
                           select num;

            foreach (int num in numQuery)
                Console.Write(num + " ");

            Console.WriteLine("\n");
            Console.WriteLine(numQuery.Sum());



























        }
    }
}
