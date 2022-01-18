namespace TurboCollections
{
   
    public class TurboList<T>
    {

        T[] items = Array.Empty<T>();
        public TurboList()
        {
            Console.WriteLine("Hello, Turbo!");
        }
        public int Count => items.Length;
        
        
        public void Add(T item)
        {
            if (items.Length > 1 &&items[^1] == null)
            {
               items = ResizeArray( items.Length); 
            }
            else
            {items = ResizeArray( 1); 
                
            }

            // if (items == Array.Empty<T>())
            // {
            //     ResizeArray(4);
            // }
            //
            // if(items[^1] == null){  
            //     items = ResizeArray( 4); 
            // }
            // if(items[^1].Equals("")){      
            //     items = ResizeArray( 4); 
            // }
            
            
            //Asigning the new element
            items[Count-1] = item;
            
        }

        T[] ResizeArray(int sizeChange)
        {
            //Resizing the array
            T[] newArray = new T[Count + sizeChange];
            if (items != Array.Empty<T>())
            {
                for (int i = 0; i < Count; i++)
                {
                    newArray[i] = items[i];
                }
            }
            
            return newArray;
        }

        public T Get(int index)
        {
            return items[index];
        }

        public T Set(int index, T value)
        {
            return items[index] = value;
        }

        public void Clear()
        {
            items = Array.Empty<T>();
        }
/// <summary>
/// // Removes one item from the list.
/// </summary>
/// <param name="index"></param>
       // public void RemoveAt(int index)
       // {
       //     //items[index] = default;
       //     for(var i = index; i < items.Length-1; i++ )
       //     { 
       //        
       //         
       //         if (i == items.Length-1)
       //         {
       //            // items[i] = default;
       //            items = ResizeArray(-1);
       //             break;
       //         }
       //         else
       //          items[i] = items[i + 1];
       //         
       //     }
       // }

public void RemoveAt(int index)
{
    T[] newArray = new T[Count - 1];
    for (int i = 0; i < index; i++)
    {
        newArray[i] = items[i];
    }

    for (int i = index; i < (Count) - index; i++)
    {
        newArray[i] = items[i + 1];
    }

    items = newArray;
}

       public bool Contains(T item)
       {
           for (var i = 0; i < items.Length; i++)
           {
               if (items[i].Equals(item))
               {
                   return true;
               }
           }

           return false;
       }

       /// <summary>
       /// // returns the index of the given item if it is in the list, else -1.
       /// </summary>
       /// <param name="item"></param>
       /// <returns></returns>
       public int IndexOf(T item)
       {
           for (var i = 0; i < Count; i++)
           {
               if (items[i].Equals(item))
               {
                    return i;
               }
           }

            return -1;
       }
       
       public IEnumerable<int> AllIndicesOf(T item)
       {
           bool hasElement = false;
           for (var i = 0; i < Count; i++)
           {
               if (items[i].Equals(item))
               {
                   

                   hasElement = true;
                   yield return i;
               }
           }


           if (hasElement == false)
           {
               yield return -1;
           }
           
       }

       public void Remove(T item)
       {
           
       }

       public void AddRange(IEnumerable<T> things)
       {
           
           foreach (var thing in things)
           {
               Add(thing);
           }
       }

    } 
}
