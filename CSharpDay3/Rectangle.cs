namespace CSharpDay3
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public double Area()
        {
            return Width * Length;
        }
    }
}