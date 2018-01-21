using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class VektorDemo
    {
        public static void Main()
        {
            Vektor a = new Vektor(1, 2);
            Vektor b = new Vektor(10, 10);
            Vektor c = new Vektor();
            c = a + b;
            c.show();
            Console.ReadKey();
        }
    } 
}
