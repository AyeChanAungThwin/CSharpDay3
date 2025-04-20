namespace CSharpDay3
{
    public class SizePredicate: Predicate<Product>
    {
        private Size _size;

        public SizePredicate(Size size)
        {
            _size = size;
        }
        public bool isMatched(Product data)
        {
            return data.Size == _size;
        }
    }
}