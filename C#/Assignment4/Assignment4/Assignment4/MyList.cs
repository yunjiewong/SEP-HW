using System;
namespace Assignment4
{
	public class MyList<T>
	{
		int size = 0;
		T[] list;
		public MyList(int size)
		{
			list = new T[size];
		}

		public void Add(T element)
        {
			list[size] = element;
			size++;
		}

        public T? Remove(int index)
        {
            if (list[index] != null)
            {
                for (int i = index; i < size - 1; i++)
                {
                    list[i] = list[i + 1];
                }
                list[size - 1] = default;
                size--;
                return list[index];
            }
            else
                throw new ArgumentException();
        }

        public bool Contains(T element)
        {
            foreach(var i in list)
            {
                if ( i.Equals(element))
                    return true;
            }
            return false;
        }

        public void Clear()
        {
            size = 0;
            list = new T[size];
        }

        public T Find(int index)
        {
            try
            {
                return list[index];
            }
            catch
            {
                throw new ArgumentException("Value does not fall within the expected range");
            }
          
        }

        public void InsertAt(T element,int index)
        {
            if (size+1 > list.Length)
                throw new ArgumentException("Value does not fall within the expected range");
        
             
            for (int i = size; i > index; i--)
            {
                list[i] = list[i - 1];
            }
            list[index] = element;
            size--;
        }
        public void DeleteAt( int index)
        {
            for(int i = index; i <size-1; i++)
            {
                list[i] = list[i + 1];
            }
            list[size - 1] = default;
            size--;
        }

    }
}

