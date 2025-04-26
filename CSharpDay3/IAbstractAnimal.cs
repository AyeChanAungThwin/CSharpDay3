using System;

namespace CSharpDay3
{
    public abstract class IAbstractAnimal: IAnimal
    {
        public void eat()
        {
            Console.WriteLine("Eating!");
        }

        public void sleep()
        {
            Console.WriteLine("Sleeping!");
        }

        public void sex()
        {
            Console.WriteLine("Sex!");
        }
    }
}