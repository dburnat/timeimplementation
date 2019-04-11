using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacjaTime
{
   

    class Program
    {
        static void Main(string[] args)
        {

            Time czas1 = new Time(12, 0, 0);
            Time czas2 = new Time(12, 1);
            Time czas3 = new Time(12);
            Time czas4 = new Time();
            Console.WriteLine($"czas1: {czas1}");
            Console.WriteLine($"czas2: {czas2}");
            Console.WriteLine($"czas3: {czas3}");
            Console.WriteLine($"czas4: {czas4}");
            Console.WriteLine("________");
            Console.WriteLine("Time test \n");
            TimePeriod timePeriodTest = new TimePeriod(2, 20, 20);

            Console.WriteLine($"{czas1} {czas2}                     = equals {czas1.Equals(czas2)}");
            Console.WriteLine($"{czas1} {czas2}                     = compare {czas1.CompareTo(czas2)}");
            Console.WriteLine($"{czas1} + {czas2}                   = {czas1 + czas2}");
            Console.WriteLine($"{czas1} - {czas2}                   = {czas1 - czas2}");
            Console.WriteLine($"{czas1}.Plus({timePeriodTest})               = {czas1.Plus(timePeriodTest)}");
            Console.WriteLine($"Time.Plus({czas1}, {timePeriodTest})         = {Time.Plus(czas1,timePeriodTest)}");
            Console.WriteLine($"{czas1} == {czas2}                  = {czas1 == czas2}");
            Console.WriteLine($"{czas1} != {czas2}                  = {czas1 != czas2}");
            Console.WriteLine($"{czas1} > {czas2}                   = {czas1 > czas2}");
            Console.WriteLine($"{czas1} < {czas2}                   = {czas1 < czas2}");
            Console.WriteLine($"{czas1} >= {czas2}                  = {czas1 >= czas2}");
            Console.WriteLine($"{czas1} <= {czas2}                  = {czas1 <= czas2}\n");


            TimePeriod timePeriod1 = new TimePeriod(12, 0, 0);
            TimePeriod timePeriod2 = new TimePeriod(12, 1);
            TimePeriod timePeriod3 = new TimePeriod(12);
            TimePeriod timePeriod4 = new TimePeriod();
            TimePeriod timePeriod5 = new TimePeriod(czas1, czas2);
            Console.WriteLine($"timePeriod1: {timePeriod1}");
            Console.WriteLine($"timePeriod2: {timePeriod2}");
            Console.WriteLine($"timePeriod3: {timePeriod3}");
            Console.WriteLine($"timePeriod4: {timePeriod4}");
            Console.WriteLine($"timePeriod5(czas1,czas2): {timePeriod5}");
            Console.WriteLine("________");
            Console.WriteLine("TimePeriod test \n");

            Console.WriteLine($"{timePeriod1} {timePeriod2}                     = equals {timePeriod1.Equals(timePeriod2)}");
            Console.WriteLine($"{timePeriod1} {timePeriod2}                     = compare {timePeriod1.CompareTo(timePeriod2)}");
            Console.WriteLine($"{timePeriod1} + {timePeriod2}                   = {timePeriod1 + timePeriod2}");
            Console.WriteLine($"{timePeriod1} - {timePeriod2}                   = {timePeriod1 - timePeriod2}");
            Console.WriteLine($"{timePeriod1}.Plus({timePeriodTest})              = {timePeriod1.Plus(timePeriodTest)}");
            Console.WriteLine($"TimePeriod.Plus({timePeriod1}, {timePeriodTest})  = {TimePeriod.Plus(timePeriod1, timePeriodTest)}");
            Console.WriteLine($"{timePeriod1} == {timePeriod2}                  = {timePeriod1 == timePeriod2}");
            Console.WriteLine($"{timePeriod1} != {timePeriod2}                  = {timePeriod1 != timePeriod2}");
            Console.WriteLine($"{timePeriod1} > {timePeriod2}                   = {timePeriod1 > timePeriod2}");
            Console.WriteLine($"{timePeriod1} < {timePeriod2}                   = {timePeriod1 < timePeriod2}");
            Console.WriteLine($"{timePeriod1} >= {timePeriod2}                  = {timePeriod1 >= timePeriod2}");
            Console.WriteLine($"{timePeriod1} <= {timePeriod2}                  = {timePeriod1 <= timePeriod2}\n");









        }
    }
}
