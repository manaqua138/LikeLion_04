using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study34
{



    //부모클래스 (기본유닛)
    class Unit
    {
        public string Name { get; set; } = "Unknown";
        public int Health { get; set; } = 0;
        public int Mana { get; set; } = 0;
        public int AttackDamage { get; set; } = 0;
        public int SpellDamage { get; set; } = 0;

        public List<string> Skills { get; set; } = new List<string>(10);        

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이 기본 공격을 합니다. ");
        }


        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동합니다. ");
        }
    }

    //SCV유닛 (건설과 수리 기능)
    class Ezreal : Unit
    {
        public int PassiveStacks { get; set; } = 0;
        public bool isWMarked { get; set; } = false;

        public double W_damage { get; set; } = 0;
        
        public Ezreal()
        {
            Name = "Ezreal";
            Health = 600;
            Mana = 375;
            AttackDamage = 60;
            SpellDamage = 0;
            Skills.Add("Rising_spell_force");
            Skills.Add("Mystic_Shot");
            Skills.Add("Essence_Flux");
            Skills.Add("Arcane_Shift");
            Skills.Add("Trueshot_Barrage");
            W_damage = 80 + 1.0 * AttackDamage + 0.7 * SpellDamage;
        }

        public void PassiveSkill()
        {
            if (PassiveStacks < 5)
                PassiveStacks++;
        }

        public void Q_Skill()
        {
            double Q_damage = 20 + 1.3 * AttackDamage + 0.15* SpellDamage;
   
            if (isWMarked == true)
            {
                Console.WriteLine($"상대방에게 {Q_damage + W_damage} 데미지를 입혔습니다!");
                Mana += 60;
                isWMarked = false;
            }
            else
            {
                Console.WriteLine($"상대방에게 {Q_damage} 데미지를 입혔습니다!");
                Mana -= 28;
            }

            PassiveSkill();
        }

        public void W_Skill()
        {

            isWMarked = true;
            Mana -= 50;
            Console.WriteLine("정수의 흐름이 적중했습니다!");
            PassiveSkill();

        }

        public void E_Skill()
        {
            double E_damage = 80 + 0.5 * AttackDamage + 0.75 * SpellDamage;

            Console.WriteLine($"비전 이동으로 회피하였습니다!");

            if (isWMarked == true)
            {
                Console.WriteLine($"상대방에게 {E_damage + W_damage} 데미지를 입혔습니다!");
                Mana += 60;
                isWMarked = false;
            }
            else
            {
                Console.WriteLine($"상대방에게 {E_damage} 데미지를 입혔습니다!");
                Mana -= 70;
            }
            PassiveSkill();
        }

        public void R_Skill()
        {
            double R_damage = 350 + 1.0 * AttackDamage + 0.9 * SpellDamage;

            Console.WriteLine($"정조준 일격을 발사하였습니다!");

            if (isWMarked == true)
            {
                Console.WriteLine($"상대방에게 {R_damage + W_damage} 데미지를 입혔습니다!");
                Mana += 60;
                isWMarked = false;
            }
            else
            {
                Console.WriteLine($"상대방에게 {R_damage} 데미지를 입혔습니다!");
                Mana -= 100;
            }

            PassiveSkill();
        }


    }


    class Program
    {
 
        static void Main(string[] args)
        {
 
            Ezreal ezreal = new Ezreal();

            Console.WriteLine($"챔피언: {ezreal.Name}");
            Console.WriteLine($"체력: {ezreal.Health}, 마나: {ezreal.Mana}");
            Console.WriteLine($"공격력: {ezreal.AttackDamage}, 주문력: {ezreal.SpellDamage}");
            Console.WriteLine($"보유 스킬: {string.Join(", ", ezreal.Skills)}");
            Console.WriteLine();

            ezreal.Attack();
            Console.WriteLine();

            ezreal.W_Skill();
            Console.WriteLine($"현재 마나: {ezreal.Mana}");
            Console.WriteLine($"현재 패시브 스택: {ezreal.PassiveStacks}");
            Console.WriteLine();

            ezreal.Q_Skill();
            Console.WriteLine($"현재 마나: {ezreal.Mana}");
            Console.WriteLine($"현재 패시브 스택: {ezreal.PassiveStacks}");
            Console.WriteLine();

            ezreal.E_Skill();
            Console.WriteLine($"현재 마나: {ezreal.Mana}");
            Console.WriteLine($"현재 패시브 스택: {ezreal.PassiveStacks}");
            Console.WriteLine();

            ezreal.R_Skill();
            Console.WriteLine($"현재 마나: {ezreal.Mana}");
            Console.WriteLine($"현재 패시브 스택: {ezreal.PassiveStacks}");
            Console.WriteLine();





        }
    }
}