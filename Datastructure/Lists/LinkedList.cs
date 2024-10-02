using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace Lists
{
    public class LinkedList : List
    {
        private class LinkedNode
        {
            public object e;
            public LinkedNode next;
            public LinkedNode back;
            public LinkedNode(object e, LinkedNode back, LinkedNode next)
            {
                this.e = e;
                this.next = next;
                this.back = back;
            }
        }
        private int SIZE;
        private LinkedNode first = new LinkedNode(null, null, null);
        public LinkedList()
        {
            first.next = first.back = first;
        }
        public void add(int index, object e)
        {
            
                addBefore(noteAt(index), e);

        }
        private void addBefore(LinkedNode node, object e)
        {
            LinkedNode before = node.back;
            LinkedNode here = new LinkedNode(e, before, node);
            before.next = node.back = here;
            SIZE++;
        }

        public void add(object e)
        {
            addBefore(first, e);
        }

        public bool contains(object e)
        {
            return indexOf(e) != -1;
        }

        public object get(int index)
        {
            return noteAt(index).e;
        }

        public int indexOf(object e)
        {
            LinkedNode node = first.next;
            for (int i = 0; i < SIZE; i++)
                if (node.e.Equals(e))
                    return i;
            return -1;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public void remove(int index)
        {
            removeNode(noteAt(index));
        }

        public void remove(object e)
        {
     
        
                int i = indexOf(e);
            if (i > 0)
            {
                
            LinkedNode node = noteAt(i);
                removeNode(node);
            }
          
            

        }

        public void set(int index, object e)
        {
            noteAt(index).e = e;
        }

        public int size()
        {
            return SIZE;
        }
        private LinkedNode noteAt(int index)
        {
            LinkedNode node = first;
            for (int i = -1; i < index; i++)
            {
                node = node.next;
            }
            return node;
        }
        private void removeAfter(LinkedNode node)
        {
            if (node.next != null) 
            {
                node.next = node.next.next;
            SIZE--;
            }
        }
        private void removeNode(LinkedNode node)
        {
            LinkedNode before = node.back;
            LinkedNode after = node.next;
            before.next = after;
            after.back = before;
            SIZE--;
        }
    }
}
