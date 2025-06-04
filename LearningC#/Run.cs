using Conditions;
using HelloWorld;
using operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_
{
    public class Run
    {
        public static void Main(string[] args)
        {
            Week1 W1 = new Week1();
            Console.WriteLine("Week 1");

            Console.WriteLine("\n");

            W1.HelloWorld();
            W1.Variables();
            W1.Concatenation();
            W1.convertDataTypes();
            W1.userInput();
            Console.WriteLine("\n");
            Console.WriteLine("Week 2");
            Console.WriteLine("\n");

            Week2 W2 = new Week2();
            W2.operators();
            W2.comparison();
            W2.logicalOperators();
            W2.MathFunc();
            W2.concatenation2();

            Console.WriteLine("\n");
            Console.WriteLine("Week 3");
            Console.WriteLine("\n");
            Week3 W3 = new Week3();
            W3.ifStatments();
            W3.switchStatement();   
            W3.whileLoop();
            W3.forLoop();
            W3.forEachLoop();
        }
    }
}
