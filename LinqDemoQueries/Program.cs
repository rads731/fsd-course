using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemoQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var num = new int[] { 1, 2, 3, 4, 5 };
            //// var res = num.Aggregate((a,b)=> a * b);
            ////var res = num.Average();
            ////var res = num.Count();
            //var res = num.AsEnumerable();   
            //foreach(var str in res)
            //{
            //    Console.WriteLine(str);
            //}

            //var vegie = new List<string> { "Potato", "Onion", "Cucumber", "Tomato"};
            //var veg = vegie.Cast<string>();
            //foreach(var v in veg)
            //{
            //    Console.WriteLine(v);
            //}
            //Object[] objects = { "ABC", 54, 34.2, null };
            //var resOne = objects.OfType<object>();
            //foreach(var obj in res)
            //{
            //    Console.WriteLine(obj);
            //}
            //Console.WriteLine("Aggregate result is "+res);

            EngToGerman[] engToGermen =
            {
                new EngToGerman{EnglishSalute = "GoodMorning", GermanSalute = "Adiue Morne"},
                new EngToGerman {EnglishSalute ="Good Day", GermanSalute = "Adiue Day"},
                new EngToGerman { EnglishSalute = "Good Evening", GermanSalute = "Adiue Evening"}, 
            };
            var res = engToGermen.ToDictionary(a => a.EnglishSalute, b => b.GermanSalute);
            foreach(KeyValuePair<string,string> dic in res)
            {
                Console.WriteLine($"English Salute : {dic.Key}, German Salute : {dic.Value}");
            }

            int[] nums = { 1, 2, 3, 4, 5 };
            var res1 = nums.ToDictionary(k => k, v => (v % 2) == 1 ? "Odd" : "Even");
            foreach(var dict in res1)
            {
                Console.WriteLine($"{dict.Key},{dict.Value}");
            }

            string[] words = { "one", "two", "three", "four", "five" };
            var res2 = words.ToLookup(w => w.Length);
            Console.WriteLine(res2);
        }
    }

    class EngToGerman
    {
        public string EnglishSalute { get; set; }
        public string GermanSalute { get; set; }
    }
}
