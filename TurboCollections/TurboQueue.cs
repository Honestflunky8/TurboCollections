namespace TurboCollections;

public class TurboQueue<T>
{
   T[] items = Array.Empty<T>();

   public int Count
   {
      get;
      set;
   }

   public void Enqueue(T item)
   {
      EnsureSize(Count+1);
      items[Count] = item;
      Count++;

   }

   public T Peek()
   {
      return items[0];
   }

   /// <summary>
   /// // returns the item in the front of the queue and removes it at the same time.
   /// </summary>
   /// <returns></returns>
   // public T Dequeue()
   // {
   //    var returnedItem = items[0];
   //    
   //    
   // }
   
   
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
}