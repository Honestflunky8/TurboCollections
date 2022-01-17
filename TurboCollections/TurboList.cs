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
            items = ResizeArray(1);
            
            //Asigning the new element
            items[Count-1] = item;
            
        }

        T[] ResizeArray(int sizeChange)
        {
            //Resizing the array
            T[] newArray = new T[Count + sizeChange];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = items[i];
            }
            return newArray;
        }

        public T Get(int index)
        {
            return items[index];
        }

        public void Clear()
        {
            items = Array.Empty<T>();
        }

       public void RemoveAt(int index)
       {
           //items[index] = default;
           for(var i = index; i < items.Length-1; i++ )
           { 
              
               
               if (i == items.Length-1)
               {
                  // items[i] = default;
                  items = ResizeArray(-1);
                   break;
               }
               else
                items[i] = items[i + 1];
               
           }
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

       // public int IndexOf(T item)
       // {
       //     
       // }

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
