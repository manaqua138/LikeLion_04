using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study20
{
    class Person
    {
        public string Name;
        public int Age;

        //기본 생성자 
        //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
        //클래스와 같은 이름을 가지며, 반환형이 없다.(void도 사용하지 않음)
        //객체를 만들 때 필요한 초기값을 설정할 때 사용한다.

        public Person() 
        {
            Name = "이름 없음";
            Age = 0;
            Console.WriteLine("기본 생성자가 실행됨");
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("매개변수 생성자가 실행됨");
        }


        public void ShowInfo()
        {
            Console.WriteLine("이름 : " + Name);
            Console.WriteLine("나이 : " + Age);
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            //클래스
            //
            Person p1 = new Person("철수", 25); //객체 생성  instance 
            Person p2 = new Person(); //객체 생성  instance 
            Person p3 = new Person(); //객체 생성  instance 

            p2.Name = "영희";
            p2.Age = 20;

            p1.ShowInfo();
            p2.ShowInfo();
            p3.ShowInfo();


        }
    }
}