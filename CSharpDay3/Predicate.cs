namespace CSharpDay3
{
    public interface Predicate<T>
    {
        bool isMatched(T data);
    }
}