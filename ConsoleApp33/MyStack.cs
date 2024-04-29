using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class MyStack<T> :IEnumerable
    {
        private T[] _arr;

        public int Count { get; private set; }

        public int Capacity { get; private set; }

        public MyStack()
        {
            Capacity = 4;
            _arr = new T[Capacity];
        }

        public MyStack(int capacity)
        {
            Capacity = capacity;
            _arr = new T[capacity];
        }

        public MyStack(ICollection<T> c) 
        {
            Capacity = c.Count;
            _arr = new T[c.Count];
        }

        public void Push(T value) 
        {
            if (Count == Capacity) 
            { 
                Capacity *= 2;
                Array.Resize(ref _arr, Capacity);
            }
            if (Count == 0)
            {
                _arr[Count] = value;
                Count++;
            }
            else
            {
                for (int i = Count; i > 0; i--) 
                {
                    _arr[i] = _arr[i-1];
                    
                }
                _arr[0] = value;
                Count++;
            }
            
            
        }

        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            for (int i = 1; i < Count; i++)
            {
                _arr[i - 1] = _arr[i];
            }
            Count--;

                if (Capacity / 2 >= Count)
                {
                Capacity /= 2;
                Array.Resize(ref _arr, Capacity);
            }
        }


        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return _arr[0];
        }

        public IEnumerator GetEnumerator()
        {
           for(int i = 0; i < Count; i++) 
            {
                yield return _arr[i];
            }
        }

    }
}
