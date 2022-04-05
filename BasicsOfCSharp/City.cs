using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    public  class City
    {
        public void Do()
        {
            string[] cities = { "Kolkata", "Delhi", "Mumbai", "Chennai", "Bangalore" };
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
