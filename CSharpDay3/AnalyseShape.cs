using System;

namespace CSharpDay3
{
    public class AnalyseShape<T1, T2>
    {
        private Pierce<T1> _t1;
        private Punctured<T2> _t2;
        
        public AnalyseShape(Pierce<T1> t1, Punctured<T2> t2)
        {
            _t1 = t1;
            _t2 = t2;
        }

        public void result()
        {
            if (_t1.name.ToString().ToLower().Equals("pencil") &&
                _t2.name.ToString().ToLower().Equals("apple"))
            {
                Console.WriteLine("PPAP");   
            }
            else if (_t1.name.ToString().ToLower().Equals("arrow") &&
                     _t2.name.ToString().ToLower().Equals("heart"))
            {
                Console.WriteLine("Loved!");
            }
            
        }
    }
}