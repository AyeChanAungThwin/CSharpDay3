using System;

namespace CSharpDay3
{
    public class Car
    {
        /*private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }
        
        private bool _gas;

        public bool Gas
        {
            get => _gas;
            set
            {
                _gas = value;
            }
        }
        */
        
        public string Name { get; set; }
        public bool Gas { get; set; }
        
        public Car()
        {
            Name = "Unknown!";
            Gas = false;
        }

        public bool Equals(Car car)
        {
            return Name.Equals(car.Name) && Gas == car.Gas;
        }
        
        public void drive(bool canDrive=false)
        {
            if (Gas && canDrive)
                Console.WriteLine($"{Name} is driving!");
            else
                Console.WriteLine($"Car: {Name} cannot drive!");
        }
    }
}