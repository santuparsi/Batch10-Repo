using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo4
    {
        static void Main()
        {
            int[] numbers = { 12, 23, 32, 21, 45, 56, 67, 65, 43, 78, 89 };
            //display square of array no;s>1000
            var result = from i in numbers
                         let n = i * i
                         where n>1000
                         select n;
            foreach (var item in result)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
