using System.Collections.Generic;

namespace CSharpDay3
{
    public interface Filter<T>
    {
        void filter(List<T> data, Predicate<T> item);
    }
}