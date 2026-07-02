using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class linq2
    {
       public static void run()
        {
            int[] number = { 10, 20, 30, 40, 50, };
            string[] names = { "ram" , "sita" };

            //All
            Console.WriteLine("All number are grater then 5");
            Console.WriteLine(number.All(n => n > 5));

            //Min 
            Console.WriteLine("Minimum numbber");
            Console.WriteLine(number.Min());

            //Max
            Console.WriteLine("Maximum number");
            Console.WriteLine(number.Max());

            //Average
            Console.WriteLine("Average number");
            Console.WriteLine(number.Average());

            //SingleorDefault
            Console.WriteLine("singleordefault");
            int result = number.SingleOrDefault(n => n == 30);
            Console.WriteLine(result); // match number then 0 return and multi match return exception 

            //SelectMany
            Console.WriteLine("select many");//string form data use here 
            var result1 = names.SelectMany(names => names);
            foreach (var name in result1)
            {
                Console.WriteLine(name);

            }

            //join 
            var student = new List<(int id, string name)>
            {
                (1,"ram"),
                (2,"sita"),
                (3,"gita")
            };
            var mark = new List<(int stuid, int mark)>
            {
                (1, 90),
                (2, 80),
                (3, 70)
            };
            var result7 = student.Join(
                mark,
                s => s.id,
                m => m.stuid,
                (s, m) => new { s.name, m.mark });
            foreach (var r in result7)
            {
                Console.WriteLine($"{r.name} - {r.mark}");
            }
        }
}
}
