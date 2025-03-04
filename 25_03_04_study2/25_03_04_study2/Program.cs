using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _25_03_04_study2
{
    class Program
    {

        class Cup<T>
        {
            public T Content { get; set; }
        }

        class SimpleCollection : IEnumerable<int>
        {
            private int[] data = { 1, 2, 3, 4, 5 };

            public IEnumerator<int> GetEnumerator()
            {
                foreach (var item in data)
                {
                    yield return item;
                }
            }
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        static void Main(string[] args)
        {
            //int valueType = 10;
            //object referenceType = valueType;

            //valueType = 20;

            //Console.WriteLine($"ValueType : {valueType}");
            //Console.WriteLine($"ReferenceType : {referenceType}");

            //int value = 42;
            //object boxed = value;
            //int unboxed = (int)boxed;

            //Console.WriteLine($"Boxed : {boxed}, Unboxed : {unboxed}");

            //// is 연산자 

            //object obj = "Hello";

            //Console.WriteLine(obj is string); //true
            //Console.WriteLine(obj is int); //false

            //// as 연산자로 형식 변환하기

            //object obj2 = "Hello";
            //string str = obj2 as string;

            //Console.WriteLine(obj2 is string);
            //Console.WriteLine(str is string);

            //string greeting = "Hello";
            //string name = "Alice";

            //string message = greeting + "," + name + "!";
            //Console.WriteLine(message);

            //Console.WriteLine($"Length of name : {name.Length}"); // 문자열 길이
            //Console.WriteLine($"To Upper : {name.ToUpper()}"); // 대문자 변환
            //Console.WriteLine($"Substring : {name.Substring(1)}"); //부분 문자열

            //string text = "C# is awesome!";
            //Console.WriteLine($"Cotains 'awesome' : {text.Contains("awesome")}");
            //Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
            //Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
            //Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome", "great")} ");

            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(",");
            //sb.Append("World!");
            //Console.WriteLine(sb.ToString());

            //String과 StringBuilder클래스 성능차이 비교
            //반복적으로 문자열을 수정할때 StringBuilder가 효율적이다.

            //int iterations = 10000;

            //Stopwatch sw = Stopwatch.StartNew();

            //string text = "";

            //for (int i = 0; i < iterations; i++)
            //{
            //    text += "a";
            //}

            //sw.Stop();
            //Console.WriteLine($"String  : {sw.ElapsedMilliseconds}ms");

            //sw.Restart();
            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < iterations; i++)
            //{
            //    sb.Append("a");
            //}

            //sw.Stop();
            //Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}ms");

            //try catch 에러사항 관리

            //try
            //{
            //    int[] numbers = { 1,2,3};
            //    for( int i = 0; i < 6; i++)
            //    Console.WriteLine(numbers[i]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Error:{ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Finished.");
            //}

            ////Exception 클래스 
            ////모든예외의 기본 클래스입니다.

            //try
            //{
            //    int number = int.Parse("abc");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"General Error : {ex.Message}");
            //}

            //try
            //{
            //    int age = -5;
            //    if (age < 0)
            //    {
            //        throw new ArgumentException("Age cannot be negative");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Exception : {ex.Message}");
            //}


            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            //names.Add("Dave");
            //names.Remove("Bob");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(list[1]);
            //list.Insert(1, 100);
            //Console.WriteLine(list[1]);

            //Console.WriteLine(list[0]);

            //list.Insert(1, 100);
            //Console.WriteLine(list.Count);

            //list[2] = 200;

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            ////Stack 

            //Stack stack = new Stack();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            //Queue queue = new Queue();

            //queue.Enqueue("q");
            //queue.Enqueue("w");
            //queue.Enqueue("e");
            //queue.Enqueue("r");
            //queue.Enqueue("점멸");
            //queue.Enqueue("평타");


            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            //ArrayList 생성
            //크기가 동적으로 조정되는 배열, 다양한 형식의 데이터를 저장할수있다.
            //ArrayList arrayList = new ArrayList();

            ////요소추가
            //arrayList.Add(1);  //정수
            //arrayList.Add("Hello");  //문자열
            //arrayList.Add(3.14);    //실수


            ////요소 접근
            //Console.WriteLine("ArrayList 요소: ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            ////요소 제거
            //arrayList.Remove(1);

            //Console.WriteLine("\n ArrayList요소 제거 후: ");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Hashtable 클래스
            //키-값 쌍을 저장하는 컬렉션이다. 
            //키를 이용해 값을 빠르게 검색


            //Hashtable hashtable = new Hashtable();

            ////키-값 쌍 추가
            //hashtable["Alice"] = 25;
            //hashtable["Bob"] = 30;
            //hashtable["포션"] = 20;

            //Console.WriteLine("Hashtable 요소:");

            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            //}


            ////특정 키의 값 가져오기
            //Console.WriteLine($"\n Alice의 나이 : {hashtable["Alice"]}");

            ////요소제거
            //hashtable.Remove("Bob");

            //Console.WriteLine("Hashtable 요소:");

            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            //}

        
            //Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            //Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            //Console.WriteLine($"CupOfString: {cupOfString.Content}");
            //Console.WriteLine($"cupOfInt: {cupOfInt.Content}");

            //Stack<int> stack = new Stack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            //names.Add("Dave");


            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}




            var collection = new SimpleCollection();

            foreach (var i in collection)
            {
                Console.WriteLine(i);
            }
       

    }
    }
}
