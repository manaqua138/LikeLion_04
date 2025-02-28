using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_02_28_study3
{

    class Person
    {
        private int count = 100; //내부변수

        //값 설정하기
        //public string Name //프로퍼티 간단하네
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        public string Name { get; set; } // 캬 이거지
        
        //public int Count
        //{
        //    get { return count; } // 읽기만 가능
        //}

        public int Count { get { return count; } }

        public float Balanec { get; private set; }  // 가져오기는 가능하지만 세팅은 내부함수로만 가능

        public void AddBal()
        {
            Balanec += 100;
        }
    }

    class Marin
    {
        public string Name { get; } = "마린";
        public int Mineral { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            
            p.Name="홍길동";
            p.AddBal();

            Console.WriteLine("이름 : " + p.Name + " Count : " + p.Count + " Balanec : " + p.Balanec);

            Marin m1 = new Marin();

            Console.WriteLine($"이름 : {m1.Name}, 미네랄 : {m1.Mineral}");

        }
    }
}
