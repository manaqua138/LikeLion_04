using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_03_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Charlie", "Alice", "Bob" };
            //var sortedNames = names.OrderBy(n => n);

            //foreach(var name in sortedNames)
            //{
            //    Console.WriteLine(name);
            //}

            //var firstName = names.First(n => n.StartsWith("A"));

            //Console.WriteLine($"First name starting with A: {firstName}");

            //int[] nums = { 5, 3, 8, 1 };

            //var sortedMeshod = nums.OrderBy(n => n);

            //var sortedQuery = from n in nums
            //                  orderby n
            //                  select n;

            //Console.WriteLine("Method syntax : ");
            //foreach (var n in sortedMeshod) Console.WriteLine(n);

            //Console.WriteLine("Query syntax : ");
            //foreach (var n in sortedQuery) Console.WriteLine(n);

            //select 개념
            //Linq 쿼리 연산자 중 하나
            //각 요소를 변환하여 새로운 컬렉션을 생성

            //string[] words = { "apple", "banana", "cherry" };

            //var upperWords = words.Select(w => w.ToUpper());

            //foreach (var word in upperWords)
            //{
            //    Console.WriteLine(word);
            //}

            //int[] data = { 1, 2, 3, 4, 5 };
            //int sum = 0;

            //foreach (var d in data)
            //    sum += d;

            //Console.WriteLine($"Sum : {sum}");

            //double avg = data.Average();
            //Console.WriteLine($"Average : {avg}");

            //int max = data.Max();

            //Console.WriteLine($"Max :  {max}");

            //int[] data = { 10, 20, 30, 40, 50, };
            //int target = 22;
            //int nearest = data[0];

            //foreach(var num in data)
            //{
            //    if (Math.Abs(num - target) < Math.Abs(nearest - target))
            //        nearest = num;
            //}

            //Console.WriteLine($"Nearest to {target} : {nearest}");

            //int[] data = { 5, 2, 8, 1, 9 };
            //Array.Sort(data);

            //foreach (var d in data)
            //    Console.WriteLine(d);

            //특정 값 검색하기: Search 알고리즘

            //int[] data = { 5, 2, 8, 1, 9 };
            //int target = 8;
            //int index = -1;

            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i] == target)
            //    {
            //        index = i;
            //        break;
            //    }
            //}

            //Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not found");

            //백준
            //프로그래머스

            //그룹화하기 : GROUP 알고리즘
            //데이터를 특정 기준으로 그룹화하기

            string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };

            var groups = fruits.GroupBy(f => f[0]); //첫 글자로 그룹화

            foreach (var group in groups)
            {
                Console.WriteLine($"Key : {group.Key}");

                foreach (var item in group)
                {
                    Console.WriteLine($" {item}");
                }

            }




        }
    }
}
