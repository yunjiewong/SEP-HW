using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment4
{
	public class MyStack<T>
    {
        int ElementCount = 0;
        T[] stack;

        public MyStack(int starting_size)
        { 
              stack = new T[starting_size];
        }

        public int Count()
        {
           
          return ElementCount;
            
        }

      

        public void push(T item)
        {
            
            stack[ElementCount] = item;
            ElementCount++;

        }

       

        public T Pop()
        {
            ElementCount--;

            T last_item = stack[ElementCount];
            stack[ElementCount] = default(T);

            return last_item;
        }


       
    }
}

