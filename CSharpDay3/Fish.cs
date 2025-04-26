using System;

namespace CSharpDay3
{
    public class Fish: IAbstractAnimal, ISwim
    {
        public void swim()
        {
            Console.WriteLine("Swim!");
        }
    }
}