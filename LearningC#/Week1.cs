using System;


namespace HelloWorld { 
    public class Week1
    {
        public void HelloWorld()
        {
            //This is a comment
            Console.WriteLine("Hello World");
            Console.WriteLine("My Name is Egan");
            Console.WriteLine(3 + 3);
        }
        
            public void Variables()
        {
            //initialise vars
            int integer = 4;
            double dec = 5.033;
            char charc = 'a';
            string name = "Egan";
            bool val = false;

            //Display vars
            Console.WriteLine(integer);
            Console.WriteLine(dec);
            Console.WriteLine(charc);
            Console.WriteLine(name);
            Console.WriteLine(val);
        }

        public void Constants()
        {
            const int num = 14;
            //num = 20; error 
        }

        public void Concatenation()
        {
            const string name = "Sam";
            const string lastname = "smith";
            Console.WriteLine("My name is " + name);

            Console.WriteLine("Fullname: " + name + " "+ lastname);
        }

        public void convertDataTypes()
        {
            int num = 10;
            double dec = 5.25;
            bool mybool = false;
            Console.WriteLine(Convert.ToString(num));
            Console.WriteLine(Convert.ToDouble(num));
            Console.WriteLine(Convert.ToInt32(dec));
            Console.WriteLine(Convert.ToString(mybool));
        }

        public void userInput()
        {
            Console.WriteLine("Enter Name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Name is " + name);

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + age);    
        }

    }


}