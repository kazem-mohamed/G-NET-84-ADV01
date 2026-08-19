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

#region Question 3
// A generic type can declare more than one type parameter, separated by commas inside
// the angle brackets (for example Pair<TKey, TValue>), so a single type can work with
// two independent types at the same time instead of being limited to just one.
public class Pair<TKey, TValue>
{
    public TKey Key { get; }
    public TValue Value { get; }

    public Pair(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }
}
#endregion

#region Question 4
// A generic method declares its own type parameter on the method itself, independent of
// its containing type, so the type is inferred separately for every call - for example
// Swap<T>(ref T a, ref T b) works for any type without the class that holds it needing
// to be generic.
public class SwapHelper
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
#endregion

#region Question 5
public class MaxFinder
{
    public static T FindMax<T>(T[] values) where T : IComparable<T>
    {
        T max = values[0];
        for (int i = 1; i < values.Length; i++)
        {
            if (values[i].CompareTo(max) > 0)
            {
                max = values[i];
            }
        }

        return max;
    }
}
#endregion

public class Program
{
    public static void Main(string[] args)
    {
    }
}
