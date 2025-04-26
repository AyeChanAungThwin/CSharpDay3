using System;

namespace CSharpDay3
{
    public class Lion: IAbstractAnimal, IWalk
    {
        public void walk()
        {
            Console.WriteLine("Walking!");
        }
    }
}