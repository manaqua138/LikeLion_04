using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 문자열 입력 관련 메서드
            //2. 형식변환

            //Console.Write("이름을 입력하세요 : ");
            //string userName = Console.ReadLine();
            //Console.Write("나이를 입력하세요 : ");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);

            //Console.WriteLine($"안녕하세요, {userName}님!"); // 보간 문자열
            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");
            //Console.WriteLine("내년에는 {0}살이 되겠군요!", age);

            //3. 로스트 아크

            float Ruinskill, Cardgauge, awakeningDamage, moveSpeed, mountSpeed, carrySpeed, skillCooldown;
            int maxMana, manaRegenCombat, manaRegenOutOfCombat;


            Console.Write("루인 스킬 피해를 입력하세요 : ");
            Ruinskill = float.Parse(Console.ReadLine());
            Console.Write("카드 게이지 획득량 입력하세요 : ");
            Cardgauge = float.Parse(Console.ReadLine());
            Console.Write("각성기 피해를 입력하세요 : ");
            awakeningDamage = float.Parse(Console.ReadLine());
            Console.Write("최대 마나를 입력하세요 : ");
            maxMana = int.Parse(Console.ReadLine());
            Console.Write("전투 중 마나 회복량을 입력하세요 : ");
            manaRegenCombat = int.Parse(Console.ReadLine());
            Console.Write("비전투 중 마나 회복량을 입력하세요 : ");
            manaRegenOutOfCombat = int.Parse(Console.ReadLine());
            Console.Write("이동 속도를 입력하세요 : ");
            moveSpeed = float.Parse(Console.ReadLine());
            Console.Write("탈 것 속도를 입력하세요 : ");
            mountSpeed = float.Parse(Console.ReadLine());
            Console.Write("운반 속도를 입력하세요 : ");
            carrySpeed = float.Parse(Console.ReadLine());
            Console.Write("스킬 재사용 대기시간 감소를 입력하세요 : ");
            skillCooldown = float.Parse(Console.ReadLine());

            Console.WriteLine($"루인 스킬 피해               : {Ruinskill}%");
            Console.WriteLine($"카드 게이지 획득량           : {Cardgauge}%");
            Console.WriteLine($"각성기 피해                  : {awakeningDamage}%");
            Console.WriteLine($"최대 마나                    : {maxMana}");
            Console.WriteLine($"전투 중 마나 회복량          : {manaRegenCombat}");
            Console.WriteLine($"비전투 중 마나 회복량        : {manaRegenOutOfCombat}");
            Console.WriteLine($"이동 속도                    : {moveSpeed}%");
            Console.WriteLine($"탈 것 속도                   : {mountSpeed}%");
            Console.WriteLine($"운반 속도                    : {carrySpeed}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소    : {skillCooldown}%");




        }
    }
}
