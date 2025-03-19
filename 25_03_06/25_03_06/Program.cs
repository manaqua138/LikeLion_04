using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study42
{
    public abstract class GameCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        protected GameCharacter(string name, int health, int attack, int defense)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
        }

         // 추상 클래스를 이용하여 자식 클래스가 반드시 구현해야 하는 함수를 지정할 수 있다.

        public abstract void BasicAttack(GameCharacter target);
        public abstract void SpecialAttack(GameCharacter target);

        public void TakeDamage(int damage)
        {
            int actualDamage = Math.Max(1, damage - Defense);
            Health = Math.Max(0, Health - actualDamage);

            Console.WriteLine($"{Name} 이(가) {actualDamage}의 피해를 받았습니다. 남은 체력 : {Health}");

        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter warrior = new Warrior("전사");
            GameCharacter mage = new Mage("마법사");

            Console.WriteLine("======= 전투 시작! =======");

            warrior.BasicAttack(mage);
            warrior.SpecialAttack(mage);

            mage.BasicAttack(warrior);
            mage.SpecialAttack(warrior);

            Console.WriteLine("======= 전투 종료! =======");
            Console.WriteLine($"전사 남은 체력 : {warrior.Health}");
            Console.WriteLine($"마법사 남은 체력 : {mage.Health}");


        }
    }
}