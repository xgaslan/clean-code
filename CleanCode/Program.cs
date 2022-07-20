using System;
using System.Collections.Generic;
using System.Linq;

namespace NamingConvensitionBad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var getData = A.GetDatas();
            foreach (var data in getData)
            {
                Console.WriteLine(data.a + "-" + data.b);
            }

            var t = A.GetData(1);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(t.a + "-" + t.b);
        }
    }

    public class A
    {
        private static List<B> D()
        {
            List<B> s = new List<B>()
            {
                new B(){a = 1, b = "Ali"},
                new B(){a = 2, b = "Veli"},
                new B(){a = 3, b = "Cengiz"},
                new B(){a = 4, b = "Ahmet"},
            };
            return s;
        }
        public static List<B> GetDatas()
        {
            var s = D();
            return s;
        }

        public static B GetData(int id)
        {
            var x = D();
            var y = x.FirstOrDefault(s => s.a == id);
            if (y != null)
            {
                return y;
            }
            return null;
        }

    }

    public class B
    {
        public int a { get; set; }
        public string b { get; set; }
    }
}
