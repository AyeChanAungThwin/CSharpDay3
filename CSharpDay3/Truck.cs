using System;

namespace CSharpDay3
{
    public class Truck
    {
        private Engine _engine;
        public Truck(Engine engine)
        {
            _engine = engine;
        }

        public void startTheEngine()
        {
            _engine.start();
        }

        public void stopTheEngine()
        {
            _engine.stop();
        }
        
        public void drive()
        {
            if (_engine.isEngineStarting())
            {
                Console.WriteLine("Car is moving!");
            }
            else
            {
                Console.WriteLine("Car doesn't move at all!");
            }
        }
    }
}