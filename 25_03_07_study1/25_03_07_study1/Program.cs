using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_03_07_study1
{
    
    class Character
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        //이벤트 정의 - 캐릭터가 데미지를 입었을 때 발생
        //EventHandler c# 에서 제공하는 기본 델리게이트 타입
        //외부에서 호출 불가능 , += -= 연산자로 접근 가능

        public event EventHandler OnDamaged;

        public Character (string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name}이(가) {amount}의 데미지를 입었습니다. 남은 체력 {Health}");

            //이벤트 발생 (구독자가 있는 경우에만)
            //? 연산자는 OnDamaged가 null이 아닐 때만 Invoke 메서드 호출
            //EventArgs.Empty 는 추가 데이터가 없을 때 사용하는 빈 이벤트 인자

            OnDamaged?.Invoke(this, EventArgs.Empty);
        
        }


    }
    
    
    
    
    class Program
    {
        //이벤트 핸들러 메서드
        
        static void Hero_OnDamaged(object sender, EventArgs e)
        {
            Character character = (Character)sender;

            Console.WriteLine($"이벤트 알림 : {character.Name}이(가) 데미지를 입었습니다.! " +
                $"현재 체력 : {character.Health}");
        }



        //delegate void MessageHandler(string message);

        //static void DisplayMessage(string message)
        //{
        //    Console.WriteLine($"메세지 : {message}");
        //}

        //static void DisplayUpperMessage(string message)
        //{
        //    Console.WriteLine($"대문자 메세지 : {message.ToUpper()}");
        //}





        static void Main(string[] args)
        {
            //Console.WriteLine("=== 간단한 델리게이트와 이벤트 예제 ===");

            //Console.WriteLine("델리게이트 1");

            //MessageHandler messageHandler = DisplayMessage;

            //messageHandler("안녕하세요");

            //messageHandler += DisplayUpperMessage;

            //Console.WriteLine("여러 메서드 호출 : ");
            //messageHandler("Hello"); //두 개의 함수가 동시에 사용 되어짐

            Character hero = new Character("용사", 100);

            hero.OnDamaged += Hero_OnDamaged;

            hero.TakeDamage(30);

            hero.OnDamaged -= Hero_OnDamaged;

            Console.WriteLine("이벤트 구독 취소");
            hero.TakeDamage(20);







        }
    }
}
