namespace CSharpDay3
{
    public class AndPredicate: Predicate<Product>
    {
        private Predicate<Product> _pred1;
        private Predicate<Product> _pred2;

        public AndPredicate(Predicate<Product> pred1, Predicate<Product> pred2)
        {
            _pred1 = pred1;
            _pred2 = pred2;
        }
        public bool isMatched(Product data)
        {
            return _pred1.isMatched(data) && _pred2.isMatched(data);
        }
    }
}