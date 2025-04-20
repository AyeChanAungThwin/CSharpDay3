using System;

namespace CSharpDay3
{
    public class Person
    {
        private string name;

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
        
        private int age;

        public void setAge(int age)
        {
            this.age = age;
            if (this.age < 0)
                Console.WriteLine("Age cannot be less than 0");
        }

        public int getAge()
        {
            return age;
        }

        public void output()
        {
            Console.WriteLine($"{name} - {age}");
        }
    }
}