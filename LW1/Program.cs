using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LW1
{

    class Program
    {
       
        static void Main(string[] args)
        {      
            double a = Func('A');

            double b = Func('B');

            double c = Func('C');
           
            double discr = (b * b) - (4 * a * c);
            double x;

            Console.WriteLine("Discriminant = {0}", discr);

            if (discr < 0)
            {
                Console.WriteLine("roots are complex numbers");
            }

            else if (discr == 0)
            {
                Console.WriteLine("two matching roots");
                x = -b / (2 * a);
                Console.WriteLine("x = {0}", x);
            }

            else
            {
                x = (-b + Math.Sqrt(discr)) / (2 * a);
                Console.WriteLine("x1 = {0}", x);
                x = (-b - Math.Sqrt(discr)) / (2 * a);
                Console.WriteLine("x2 = {0}", x);
            }
            
            Console.ReadLine();
        }

        static double Func(char l)
        {
            double a;
            string s;
            bool ConvertResult;
            do
            {
                Console.Write("{0} = ", l);
                s = Console.ReadLine();
                ConvertResult = double.TryParse(s, out a);
                if (ConvertResult)
                {
                    if (l == 'A')
                    {
                        if (!(a == 0))
                        {
                           return a;


                        }
                        else
                        {
                            Console.WriteLine("Enter a value other than 0");
                        }
                    }
                    else
                    {
                         return a;                   
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect value");
                }
            } while (true);
        }
    }
}
