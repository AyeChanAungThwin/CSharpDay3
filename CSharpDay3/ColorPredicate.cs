namespace CSharpDay3
{
    public class ColorPredicate: Predicate<Product>
    {
        private Color _color;
        
        public ColorPredicate(Color color)
        {
            _color = color;
        }
        
        public bool isMatched(Product data)
        {
            return data.Color == _color;
        }
    }
}