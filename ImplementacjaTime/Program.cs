using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacjaTime
{
    //TODO
    //1. String to byte

    class Program
    {
        static void Main(string[] args)
        {

            Time czas1 = new Time(12, 55, 55);
            Time czas2 = new Time(16, 50, 5);

            Console.WriteLine($"{czas1} {czas2}= equals {czas1.Equals(czas2)}");
            Console.WriteLine($"{czas1} {czas2}= compare {czas1.CompareTo(czas2)}" );
            Console.WriteLine($"{czas1} + {czas2}=  {czas1 + czas2}");
            Console.WriteLine($"{czas1} > {czas2}=  {czas1 > czas2}");
            Console.WriteLine($"{czas1} < {czas2}=  {czas1 < czas2}");
            //string[] splitted = czas1.Split(':');
            //Console.WriteLine(splitted[0]);
            //Console.WriteLine("--------");
            //byte[] zmian = Encoding.Unicode.GetBytes(splitted[0]);


            //foreach (var item in zmian)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(godzina);
            Console.WriteLine(czas2.ToString());


        }
    }
}
