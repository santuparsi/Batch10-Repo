using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo3
    {
        static void Main()
        {
            //deferred execuation
            int[] numbers = { 12, 23, 32, 21, 45, 56, 67, 65, 43, 78, 89 };
            var result = from i in numbers
                         where i % 2 == 0
                         select i;
            numbers[0] = 11;
            foreach (var item in result)
                Console.WriteLine(item);
            //Immdiate execuation
            List<int> list = (from i in numbers
                             where i > 30
                             select i).ToList();
            numbers[2] = 10;
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
