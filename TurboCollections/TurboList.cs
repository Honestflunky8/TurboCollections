namespace TurboCollections
{
   
    public class TurboList<T>
    {

        T[] items = Array.Empty<T>();
        int count;
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
        
        public TurboList()
        {
            Console.WriteLine("Hello, Turbo!");
        }

        // public void Add()
        // {
        //     
        // }
    
    } 
}
