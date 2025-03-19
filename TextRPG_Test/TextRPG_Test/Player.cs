using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    public class Character
    {
        public String Name { get; set; }
        public int iHP { get; set; }
        public int iAttack { get; set; }


        public void GetDamage(int amount) { this.iHP -= amount; }
      //  public void SetDamage(ref ) { t_player.iHP -= amount; }

    }

    public class  Player : Character
    {
 
        public void SetPlayerJob()
        {
            Console.WriteLine("직업을 선택하세요(1.기사 2.마법사 3.도둑)");
            int select = int.Parse(Console.ReadLine());

            switch(select)
            {
                case 1:
                    this.Name = "기사";
                    this.iHP = 100;
                    this.iAttack = 10;
                    break;
                case 2:
                    this.Name = "마법사";
                    this.iHP = 80;
                    this.iAttack = 20;
                    break;
                case 3:
                    this.Name = "도둑";
                    this.iHP = 90;
                    this.iAttack = 15;
                    break;
            }

        }


        public void Render()
        {
            Console.WriteLine("======================================");
            Console.WriteLine($"직업 이름 : {this.Name}");
            Console.WriteLine($"체력 : {this.iHP}\t 공격력 : {this.iAttack}");
        }



    }


}
