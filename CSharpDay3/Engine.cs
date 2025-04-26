namespace CSharpDay3
{
    public class Engine
    {
        private bool _start;
        public void start()
        {
            _start = true;
        }

        public void stop()
        {
            _start = false;
        }

        public bool isEngineStarting()
        {
            return _start;
        }
    }
}