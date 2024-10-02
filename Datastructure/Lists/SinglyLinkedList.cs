using Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class SinglyLinkedList : List
    {
        private class LinkedNode
        {

            public object e;
            public LinkedNode next;

            public LinkedNode(object e, LinkedNode next)
            {
                this.e = e;
                this.next = next;
            }
        }

        private int SIZE;
        private LinkedNode frist = new LinkedNode(null, null);


        private LinkedNode noteAt(int index)
        {
            LinkedNode node = frist;
            for (int i = -1; i < index; i++)
                node = node.next;
            return node;
        }

        public void add(object e)
        {
            add(SIZE,e);
        }
        public void add(int index, object e)
        {
            if (index <= SIZE) ;
            LinkedNode node = noteAt(index - 1);
            node.next = new LinkedNode(e, node.next);

            SIZE++;
        }
        private void removeAfter(LinkedNode node)
        {
            if (node.next != null)
            {
                node.next = node.next.next;
                SIZE--;
            }
        }


        public void remove(int index)
        {
            LinkedNode node = noteAt(index - 1);
            removeAfter(node);

        }
        public void remove(object e)
        {

            int i = indexOf(e);
            if (i > -1)
            remove(i);
        }
        public object get(int index)
        {
            return noteAt(index).e;
        }

        public void set(int index, object e)
        {
            noteAt(index).e = e;
        }


        public bool contains(object e)
        {
            return indexOf(e) != -1;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public int size()
        {
            return SIZE;
        }
        public int indexOf(object e)
        {
            LinkedNode node = frist.next;
            for (int i = 0; i < SIZE; i++)
                if (node.Equals(e))
                    return i;
            return -1;
        }
    }
}