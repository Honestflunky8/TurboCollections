namespace TurboStack;

public class TurboStack<T>
{
    T[] items = Array.Empty<T>();
    
    public int Count => items.Length;

    /// <summary>
    /// // adds one item on top of the stack.
    /// </summary>
    /// <param name="item"></param>
    public void Push(T item)
    {
        // adds one item on top of the stack.
        
        //Creates new array
        T[] newArray = new T[Count + 1];
        for (int i = 0; i < Count; i++)
        {
            newArray[i] = items[i];
        }

        //Set array to be the new array
        items = newArray;


        items[^1] = item;

    }

    /// <summary>
    /// // returns the item on top of the stack without removing it.
    /// </summary>
    /// <returns></returns>
    public T Peek()
    {
        // returns the item on top of the stack without removing it.
        return items[^1];
    }

    /// <summary>
    /// // returns the item on top of the stack and removes it at the same time.
    /// </summary>
    /// <returns></returns>
    public T Pop()
    {
        // returns the item on top of the stack and removes it at the same time.
        var value = Peek();
        
        T[] newArray = new T[Count - 1];
        for (int i = 0; i < Count - 1; i++)
        {
            newArray[i] = items[i];
        }
        //Set array to be the new array
        items = newArray;

        return value;

    }
    
    /// <summary>
    /// Empties array
    /// </summary>
    public void Clear()
    {
        items = Array.Empty<T>();
    }
}