using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    public class Week2
    {
        public void operators()
        {
            int x = 100 + 50;

            int sum1, sum2, sum3;

            sum1 = 10 + 5;
            sum2 = sum1 + 10;
            sum3 = sum2 + sum1;

            Console.WriteLine(sum3);

            Console.WriteLine( 5 + 5 );
            Console.WriteLine( 10 / 2 );
            Console.WriteLine( 10 - 5 );
            Console.WriteLine(5 * 2);
            Console.WriteLine(5 % 2);
            Console.WriteLine(x ++);
            Console.WriteLine(x --);
        }

        public void comparison()
        {
            int x = 5;
            int y = 3;
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
        }

        public void logicalOperators()
        {
            Console.WriteLine(false && true);
            Console.WriteLine(false || true);
            Console.WriteLine(!false);

        }

        public void MathFunc()
        {
            //Find Max
            Console.WriteLine(Math.Max(5, 10));

            //Find Min
            Console.WriteLine(Math.Min(5, 10));

            //Get square root
            Console.WriteLine(Math.Sqrt(4));

            //find absolute positive value of x
            Console.WriteLine(Math.Abs(-4));

            //Round to nearest whole number
            Console.WriteLine(Math.Round(3.134444));
        }

        public void concatenation2()
        {
            string fname = "Egan";
            string lname = "da silva";

            string text = $"My Full name is: {fname} {lname}";
            Console.WriteLine(text);
        }
    }
}
