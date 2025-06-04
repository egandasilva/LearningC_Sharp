using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    public class Week3
    {
        public void ifStatments()
        {
            // if
            if(20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            //else
            if (20 < 18)
            {
                //dfgdf
            }
            else
            {
                Console.WriteLine("20 is not less than 18");
            }

            // else if
            if(20 < 18)
            {
                //dfs
            }
            else if(20 == 20)
            {
                Console.WriteLine("20 is equal to 20");
            }
            else
            {
                //sdfsdf
            }

            //short hand
            int time = 20;
            /*            
                        if (time < 18)
                        {
                            Console.WriteLine("Good morning");
                        }
                        else
                        {
                            Console.WriteLine("Good Evening");
                        }
            */
            string txt = (time < 18) ? "Good Morning" : "Good Evening";
            Console.WriteLine(txt);

        }

        public void switchStatement()
        {
            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
        }

        public void whileLoop()
        {
           int i = 0;
            while (i < 4)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void forLoop()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void forEachLoop()
        {
            string[] fruits = { "appple", "banana", "orange" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);   
            }
        }

        public void arrays()
        {
            string[] cars = {"volvo", "Mazda", "BMW"};

            Console.WriteLine(cars[1]);

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
