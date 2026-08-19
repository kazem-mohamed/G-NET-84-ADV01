#region Question 1
// A generic class is a class defined with one or more type parameters (for example
// Container<T>), so the same class definition can work with many different data types
// while still being fully type-safe.
//
// Generics are used instead of writing a separate class per data type, or using object,
// because they avoid the boxing/unboxing and runtime casts that come with object, they
// let the compiler catch type mismatches at compile time instead of at runtime, and
// they let one implementation be reused for any type without duplicating code.
#endregion

#region Question 2
public class Container<T>
{
    private T item = default!;

    public void Add(T item)
    {
        this.item = item;
    }

    public T Get()
    {
        return item;
    }
}
#endregion

public class Program
{
    public static void Main(string[] args)
    {
    }
}
