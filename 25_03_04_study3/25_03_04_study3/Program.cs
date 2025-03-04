using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_03_04_study3
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> ages = new Dictionary<string, int>();

            ages["금도끼"] = 10;
            ages["은도끼"] = 5;
            ages["돌도끼"] = 1;

            foreach (var pair in ages)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

            int? nullableInt = null;

            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            nullableInt = 10;

            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            string str = null;

            if (str == null)
            {
                Console.WriteLine("DefaultValue");
            }

            Console.WriteLine(str ?? "DefaultValue");//str이 null이면 "Default Value

            //LINQ는 확장메서드 형태로 제공된다. 
            //LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할 수있습니다.
            int[] numbers = { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }


        }
    }
}
