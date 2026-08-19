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

#region Question 6
// A generic interface declares members using a type parameter, so implementers decide
// the concrete type when they implement it - for example IRepository<T> can be
// implemented as IRepository<Customer> or IRepository<Order> while sharing the same
// contract shape.
public interface IRepository<T>
{
    void Add(T item);
    T GetById(int id);
    IEnumerable<T> GetAll();
}
#endregion

#region Question 7
// The 'struct' constraint restricts a type parameter to non-nullable value types only
// (any struct, including built-in numeric types and enums), so reference types and
// Nullable<T> cannot be used as T.
public class StructConstraintExample
{
    public static bool IsDefault<T>(T value) where T : struct
    {
        return value.Equals(default(T));
    }
}
#endregion

#region Question 8
// The 'class' constraint restricts a type parameter to reference types only, so value
// types such as int or DateTime cannot be used as T.
public class ClassConstraintExample
{
    public static bool IsNull<T>(T value) where T : class
    {
        return value == null;
    }
}
#endregion

#region Question 9
// The 'new()' constraint requires the type argument to have an accessible parameterless
// constructor, which lets generic code create new instances of T with "new T()".
public class NewConstraintExample
{
    public static T CreateInstance<T>() where T : new()
    {
        return new T();
    }
}
#endregion

public class Program
{
    public static void Main(string[] args)
    {
    }
}
