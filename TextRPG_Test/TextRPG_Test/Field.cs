using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    public class Field
    {
        
        
        public void RenderField1()
        {
            Console.Write("1.사냥터 2. 종료 : ");

        }

        public void RenderField2()
        {
            Console.WriteLine("1. 초보맵\n2. 중수맵\n3.고수맵\n4.전단계\n==============");
            Console.WriteLine("맵을 선택하세요 : ");
        }
    }
}
