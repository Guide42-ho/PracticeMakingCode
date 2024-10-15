using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class ArrayQueue : Queue
    {
        private object[] data;
        private int SIZE;
        private int cap;
        private int firstindex;
        public ArrayQueue(int cap) 
        {
            this.cap = cap;
            this.data = new object[cap];
        }
        public object dequeue()
        {
            object e =peek();
            data[firstindex] = null;
            firstindex = (firstindex + 1)%data.Length;
            SIZE--;
            return e;
        }

        public void enqueue(object e)
        {
            ensureCapacity();
            data[(firstindex+SIZE++)%data.Length] = e;
        }
        public object peek()
        {
            return data[firstindex];
        }
        private void ensureCapacity() 
        {
            if (SIZE + 1 > data.Length)
            {
                object[] tempdata = new object[2 * SIZE];
                for (int i = 0; i < SIZE; i++)
                    tempdata[i] = data[i];
                data = tempdata;
            firstindex = 0;
            }
        }
        public bool isEmpty()
        {
            return SIZE == 0;
        }
        public int size()
        {
            return SIZE;
        }
    }
}
