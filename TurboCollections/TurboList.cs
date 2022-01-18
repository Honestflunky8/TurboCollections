using System.Collections;

namespace TurboCollections
{
   
    public class TurboList<T> : IEnumerable<T>
    {

        T[] items = Array.Empty<T>();

        /// <summary>
        /// Gives the amount of items inside of the List
        /// </summary>
        public int Count
        {
            get;
            private set;
        }

        /// <summary>
        /// Gives the size of the List
        /// </summary>
        public int Lenght => items.Length;
        
        /// <summary>
        /// Adds an item to the list
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            EnsureSize(Count+1);
            items[Count++] = item;
        }

        /// <summary>
        /// Increases size of the array if needed.
        /// Size of array is doubled when increased.
        /// </summary>
        /// <param name="size"></param>
        void EnsureSize(int size)
        {
            if (items.Length >= size)
            {
                return;
            }

            //Double array size or set to given size if not enough.
            int newSize = Math.Max(size, items.Length * 2);
            
            T[] newArray = new T[newSize];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = items[i];
            }
            //Assign new array 
           items = newArray;

        }

        /// <summary>
        /// Returns the item of the inserted index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Get(int index)
        {
            if (index <= items.Length)
            {
                return items[index];
            }
            else
            {
                throw new Exception("Index value does not exit in the list.");
            }
            
        }

        /// <summary>
        /// Replaces the item of the inserted index with the inserted item.
        /// Also increases size of array if inserted index is outside the bounds of the list.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        public void Set(int index, T item)
        {
            if (index >= Count)
            {
                EnsureSize(index+1);
                Count = index + 1;
            }
             items[index] = item;
        }

        /// <summary>
        /// Removes all items from list and sets Count to 0.
        /// </summary>
        public void Clear()
        {
            items = Array.Empty<T>();
            Count = 0;
        }
        
        /// <summary>
        /// // Removes one item from the list.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            if (index <= items.Length)
            {
                for (int i = index; i < Count - 1; i++)
                {
                    items[i] = items[i + 1];
                }
                Count--;
            }
            else
            {
                throw new Exception("Index not within list size.");
            }
            
        }

        /// <summary>
        /// Checks if the list contains the inserted item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
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
           for (var i = 0; i <= Count; i++)
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

       /// <summary>
       ///  Removes the specified item from the list, if it can be found.
       /// </summary>
       /// <param name="item"></param>
       public void Remove(T item)
       {
           if (items.Contains(item))
           {
               RemoveAt(IndexOf(item));
           }
           else
           {
               throw new System.Exception("Item does not exit in list");
           }
       }
       

       public void AddRange(IEnumerable<T> things)
       {
           
           foreach (var thing in things)
           {
               Add(thing);
           }
       }
       
       public IEnumerator<T> GetEnumerator()
       {
           return new Enumerator(items, Count);
       }
       

       IEnumerator IEnumerable.GetEnumerator()
       {
           return GetEnumerator();
       }
        
       public struct Enumerator : IEnumerator<T>
       {
           private readonly T[] _items;
           private readonly int _count;
           private int _index;

           public Enumerator(T[] items, int count)
           {
               _items = items;
               _count = count;
               _index = -1;
           }
           public bool MoveNext()
           {
               if (_index >= _count)
                   return false; // exception
               return ++_index < _count;
           }

           public void Reset()
           {
               _index = -1;
           }

           public T Current => _items[_index];

           object IEnumerator.Current => Current;

           public void Dispose()
           {
               Reset();
           }
       }

    } 
}
