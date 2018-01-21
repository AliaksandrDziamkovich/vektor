using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Vektor
    {
        int x, y;
        public Vektor() { x = y = 0; }
        public Vektor(int i, int j)
        {
            x = i;
            y = j;
        }

        public static Vektor operator +(Vektor op1, Vektor op2)
        {
            Vektor result = new Vektor();
            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            return result;
        }

        public static Vektor operator -(Vektor op1, Vektor op2)
        {
            Vektor result = new Vektor();
            result.x = op1.x - op2.x;
            result.y = op1.y - op2.y;
            return result;
        }
        public static Vektor operator *(Vektor op1, Vektor op2)
        {
            Vektor result = new Vektor();
            result.x = op1.x * op2.x;
            result.y = op1.y * op2.y;
            return result;
        }
        public static Vektor operator +(Vektor op1, int h)
        {
            Vektor result = new Vektor();
            result.x = op1.x + h;
            result.y = op1.y + h;
            return result;
        }

        public void show()
        {
            double xxx;
            xxx = Math.Sqrt(x * x + y  *y);
            Console.WriteLine(xxx);
     
        }
    }
}
