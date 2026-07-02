using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class linq
    {
        public static void run()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            // 1. where()
            Console.WriteLine("where ( grater then 25 )");
            var result1 = numbers.Where(n => n > 25);
            foreach (var number in result1)
            {
                Console.WriteLine(number);
            }

            // 2. select()
            Console.WriteLine("select ( multiply by 2 )");
            var result2 = numbers.Select(n => n * 2);
            foreach (var number in result2)
            {
                Console.WriteLine(number);
            }

            // 3. ordereby()
            Console.WriteLine("orderby");
            var result3 = numbers.OrderBy(n => n);
            foreach (var number in result3)
            {
                Console.WriteLine(number);
            }

            // 4. orderbydescending()
            Console.WriteLine("orderbydescending");
            var result5 = numbers.OrderByDescending(n => n);
            foreach (var number in result5)
            {
                Console.WriteLine(number);
            }

            // 6. firstordefault()
            Console.WriteLine("first or default");
            Console.WriteLine(numbers.FirstOrDefault());

            //7. Any()
            Console.WriteLine("Any");
            Console.WriteLine(numbers.Any());

            //8. count()
            Console.WriteLine("count");
            Console.WriteLine(numbers.Count());

            //9. sum ()
            Console.WriteLine("sum");
            Console.WriteLine(numbers.Sum());

            //10 take()
            Console.WriteLine("take first 3 number");
            var result10 = numbers.Take(3);
            foreach (var number in result10)
            {
                Console.WriteLine(number);
            }

            //11. skip()
            Console.WriteLine("skip first 3");
            var result11 = numbers.Skip(3);
            foreach (var number in result11)
            {
                Console.WriteLine(number);
            }

            //12. distinct()
            Console.WriteLine("distinct");
            var result12 = numbers.Distinct();
            foreach (var number in result12)
            {
                Console.WriteLine (number);
            }

            //13. contains()
            Console.WriteLine("contains 30 exist or not ");
            bool result13 = numbers.Contains(30);
            Console.WriteLine(result13);

            //14. tolist()
            Console.WriteLine("to list convert into list ");
            List<int> result14 = numbers.ToList();
            foreach (var number in result14)
            {
                Console.WriteLine(number);
            }

            //15. first()
            Console.WriteLine("first");
            int result15 = numbers.First();
            Console.WriteLine(result15);

            //16. last()
            Console.WriteLine("last");
            int result16 = numbers.Last();
            Console.WriteLine(result16);

            //17. single()
            Console.WriteLine("single");
            int result17 = numbers.Single(n => n == 30);
            Console.WriteLine(result17);

            //18. lastordefault()
            Console.WriteLine("last or default");
            int result18 = numbers.LastOrDefault();
            Console.WriteLine(result18);
        }
    }
}

