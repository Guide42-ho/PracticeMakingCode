using System;
using System.Linq;

namespace Stacks
{
    public class ArrayStack : Stack
    {
        private object[] data;
        private int SIZE;
        private int cap;
        public ArrayStack(int cap)
        {
            this.cap = cap;
            data = new object[cap];
        }
        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public object peek()
        {
            if (isEmpty()) throw new System.MissingMemberException();
            return data[SIZE - 1];
        }

        public object pop()
        {
            object e = peek(); ; // คืนค่าข้อมูลจากตำแหน่งที่ถูกต้อง
            data[--SIZE] = null; // ลดขนาด SIZE และลบข้อมูล
            return e;
        }

        public void push(object e)
        {
            //ensureCapacity();
            data[SIZE++] = e;
        }

        public int size()
        {
            return SIZE;
        }
        //private void ensureCapacity()
        //{
        //    if (SIZE + 1 > data.Length)
        //    {
        //       object[] tempdata = new object[2 * SIZE];
        //         for (int i = 0; i < SIZE; i++)
        //            tempdata[i] = data[i];
        //      data = tempdata;
        // }
        //}
        public static bool IsCorrectParentheses(String t)
        {
            String open = "({[<";
            String close = ")}]>";
            Stack Stack = new ArrayStack(t.Length);
            if (t.Any(c => "({[<)}]>".Contains(c)))
            {
                for (int i = 0; i < t.Length; i++)
                {
                    if (open.Contains(t[i]))
                    {
                        Stack.push(t[i]);
                    }
                    else if (close.Contains(t[i]))
                    {
                        if (Stack.isEmpty() || open.IndexOf((char)Stack.peek()) != close.IndexOf(t[i]))
                        {
                            return false;
                        }
                        Stack.pop();

                    }
                }
                return Stack.isEmpty();
            }
            return false;
        }
    }
}
