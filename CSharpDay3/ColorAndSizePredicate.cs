namespace CSharpDay3
{
    public class ColorAndSizePredicate: Predicate<Product>
    {
        private Color _color;
        private Size _size;

        public ColorAndSizePredicate(Color color, Size size)
        {
            _color = color;
            _size = size;
        }
        public bool isMatched(Product data)
        {
            return data.Color == _color && data.Size == _size;
        }
    }
}