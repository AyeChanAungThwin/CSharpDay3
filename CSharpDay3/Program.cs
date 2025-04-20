using System;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharpDay3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //StringTest();
            //Condition
            //ConditionIfElseIf();
            //SwitchCaseTest(11);
            //WhileLoop();
            //DoWhileLoop();
            //ForLoop();
            //ForeachLoop();
            //BreakContinue();
            //ArrayTest();

            /*var prog = new Program();
            /*var result = prog.test("Hello world");
            Console.WriteLine(result);#1#
            var result = prog.Data("Aye Chan Aung Thwin");
            Console.WriteLine(result);*/

            /*var car = new Car();
            car.drive();*/
            
            //OOP();
            
            Weeks[] weeks = { Weeks.SUNDAY , Weeks.MONDAY };

            foreach (var day in weeks)
            {
                Console.WriteLine(day.ToString().ToLower());
            }
        }

        public static void OOP()
        {
            var volvo = new Car();
            volvo.Name = "Volvo";
            volvo.Gas = true;
            volvo.drive(true);
            
            var honda = new Car();
            honda.drive(true);
            
            //Encapsulation
            var prn = new Person();
            prn.setName("Aye Chan");
            prn.setAge(-10);
            prn.output();
            
            //inheritance and polymorphism
            Animal common = new Animal();
            common.greet();

            Animal cat = new Cat();
            cat.greet();

            Animal dog = new Dog();
            dog.greet();
            
            //abstraction
            var obj1 = new Pierce<string>();
            obj1.name = "Pencil";

            var obj2 = new Punctured<string>();
            obj2.name = "Apple";

            var analysed = new AnalyseShape<string, string>(obj1, obj2);
            analysed.result();
            
            //.Equals
            var car1 = new Car();
            car1.Name = "Volvo";
            car1.Gas = true;
            car1.drive(true);
            
            var car2 = new Car();
            car2.Name = "Volvo";
            car2.Gas = true;
            car2.drive(true);
            
            Console.WriteLine(car1==car2);
            Console.WriteLine(car1.Equals(car2));
            
            //interface - blueprints
            USB keyboard = new Keyboard();
            USB mouse = new Mouse();

            USB[] devices = { keyboard, mouse };

            foreach (var usb in devices)
            {
                Console.WriteLine(usb.getName());
            }
        }

        public static void StringTest()
        {
            var data = "Aye Chan Aung Thwin";
            Console.WriteLine(data);
            Console.WriteLine(data.Length);
            Console.WriteLine(data.ToUpper());
            Console.WriteLine(data.ToLower());

            var age = 30;
            
            Console.WriteLine(data+" "+age); //Concatenation
            
            Console.WriteLine($"{data} - {age}");
            
            Console.WriteLine($"'{data[0]}' - '{data[18]}'");

            var temp = @"C:\Program Files";
            
            Console.WriteLine(temp);

            var temp1 = "Hello\n\tWorld\n\t\tHi";
            Console.WriteLine(temp1);

            var sb = new StringBuilder();

            sb.Append(data);
            sb.Append('-');
            sb.Append(age);
            
            Console.WriteLine(sb.ToString());

            double val = 8.39402;
            Console.WriteLine(val.ToString("0.0"));
        }

        public static void ConditionIfElseIf()
        {
            var english = 40;

            if (english >= 75 && english <= 100)
            {
                Console.WriteLine("You passed with distinction!");
            }
            else if (english >= 50)
            {
                Console.WriteLine("You passed the exam!");
            }
            else
            {
                Console.WriteLine("You failed the exam!");
            }
            
            //Ternary Operator
            //condition?true:false;
            var val1 = 20;
            var val2 = 21;
            var result = (val1 > val2) ? "Yes" : "No";
            Console.WriteLine(result);
        }

        public static void SwitchCaseTest(int val)
        {
            switch (val)
            {
                case 0:
                    Console.WriteLine("Sunday!");
                    break;
                case 1:
                    Console.WriteLine("Monday!");
                    break;
                case 2:
                    Console.WriteLine("Tuesday!");
                    break;
                case 3:
                    Console.WriteLine("Wednesday!");
                    break;
                case 4:
                    Console.WriteLine("Thursday!");
                    break;
                case 5:
                    Console.WriteLine("Friday!");
                    break;
                case 6:
                    Console.WriteLine("Saturday!");
                    break;
                default:
                    Console.WriteLine("Unknown!");
                    break;
            }
        }

        public static void WhileLoop()
        {
            var i = 5;
            while (i > 0)
            {
                Console.WriteLine("OK");
                i--;
            }
        }

        public static void DoWhileLoop()
        {
            var i = 0;
            do
            {
                Console.WriteLine("Hello");
            } while (i > 5);
        }

        public static void ForLoop()
        {
            for (var i = 0; i <= 10; i+=2)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"The value is even: {i}.");
                }
                else
                {
                    Console.WriteLine($"The value is odd: {i}.");
                }
            }
        }

        public static void ForeachLoop()
        {
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

            int count = 0;
            foreach (var result in cars)
            {
                if (count%2==0) Console.WriteLine(result);
                count++;
            }

            /*for (var i = 0; i < cars.Length; i++)
            {
                if (i%2!=0)
                Console.WriteLine(cars[i]);
            }*/
        }

        public static void BreakContinue()
        {
            /*for (int i = 0; i < 5; i++)
            {
                if (i == 2) break;
                Console.WriteLine(i);
            }*/
            
            for (int i = 0; i < 5; i++)
            {
                if (i == 2) continue;
                Console.WriteLine(i);
            }
        }

        public static void ArrayTest()
        {
            int[] nums = { 2, 21, 4, 45, 23 };
            
            Array.Sort(nums);

            /*for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }*/
            
            for (int i = nums.Length-1; i >= 0; i--)
            {
                Console.WriteLine(nums[i]);
            }
            
            /*Console.WriteLine("________");

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }*/
            
            Console.WriteLine("Max num is : "+nums.Max());
            Console.WriteLine("Sum is :"+nums.Sum());

            var mul = 1;
            foreach (var num in nums)
            {
                mul *= num;
            }
            Console.WriteLine(mul);
        }

        public static void MultiArray()
        {
            int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i,j]);
                }
            }
        }

        public String test(string val)
        {
            return val;
        }

        public String Data(string name)
        {
            return $"Name is : {name}";
        }

        public String Data(string name, int age)
        {
            if (age == 0) return $"Name is : {name} and age is unknown.";
            return $"{Data(name)} and age is {age}.";
        }

        public int addition(int a, int b)
        {
            return a + b;
        }
        
        public double addition(double a, double b)
        {
            return a + b;
        }
    }
}