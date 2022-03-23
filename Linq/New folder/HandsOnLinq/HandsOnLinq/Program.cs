using System;
using System.Linq;
namespace HandsOnLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datasource
            int[] numbers = { 12, 23, 32, 21, 45, 56, 67, 65, 43, 78, 89 };
            //Query Expression
            var queryResult = from k in numbers select k;
            foreach(var item in queryResult)
            {
                Console.WriteLine(item);
            }
            //fetech even values
            queryResult = from k in numbers
                          where k % 2 == 0
                          select k;
            Console.WriteLine();
            foreach (var item in queryResult)
                Console.WriteLine(item);
            //fetech even values >20
            queryResult = from k in numbers
                          where k % 2 == 0 && k>20
                          select k;
            Console.ReadKey();

        }
    }
}
