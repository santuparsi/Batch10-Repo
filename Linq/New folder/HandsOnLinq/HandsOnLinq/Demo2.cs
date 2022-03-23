using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo2
    {
        static void Main()
        {
            string[] names = { "Rohan", "Rajan", "Dinesh", "Srijan", "Suren" };
            //fetch name starts with s
            var result = from s in names
                         where s.StartsWith("S")
                         select s.ToUpper();
            result = from s in names
                     where s.Length > 3
                     orderby s ascending
                     select s;
            foreach (var item in result)
                Console.WriteLine(item);
            Console.ReadKey();
                
        }
    }
}
