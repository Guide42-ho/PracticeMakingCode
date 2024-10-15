using System;
using System.Linq;
using System.Text;

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
            ensureCapacity();
           // if(cap < SIZE +1) throw new System.StackOverflowException();
            data[SIZE++] = e;
        }

        public int size()
        {
            return SIZE;
        }
        private void ensureCapacity()
        {
            if (SIZE + 1 > data.Length)
            {
               object[] tempdata = new object[2 * SIZE];
                 for (int i = 0; i < SIZE; i++)
                    tempdata[i] = data[i];
              data = tempdata;
         }
        }
        public static bool IsCorrectParentheses(String text)
        {
            String open = "({[<";
            String close = ")}]>";
            Stack Stack = new ArrayStack(text.Length); //  ที่ขนาดarrayเท่ากับความยาวString 
            if (text.Any(c => "({[<)}]>".Contains(c))) //เช็คว่ามีวงแล็บ
            {
               foreach (char ch in text) //loop String
                {
                    if (open.Contains(ch)) //เช็ควงแล็บเปิด
                    {
                        Stack.push(ch); //เก็บวงแล็บ
                    }
                    else if (close.Contains(ch)) //เช็ควงแล็บปิด
                    {
                        if (Stack.isEmpty() || open.IndexOf((char)Stack.peek()) != close.IndexOf(ch)) //ถ้าเป็นค่าว่าง || วงแล็บบนสุดมีตำแหน่ง ไม่ตรง วงแล็บล่าสุดมีตำแหน่ง 
                        {
                            return false;
                        }
                        Stack.pop(); //เอาออก
                    }
                }
                return Stack.isEmpty(); //ส่งค่าว่างหรือไม
            }
            return false; //ไม่มีวงแล็บ false
        }
        public static string ConvertInfixToPostfix(string text) 
        {
            if (!IsCorrectParentheses(text)) 
            {
                throw new ArgumentException("Invalid expression: Unbalanced parentheses.");
            }
            StringBuilder postfixBuilder = new StringBuilder();
                for (int i = 0; i < text.Length; i++)
                {
                    char currentChar = text[i];
                    if (char.IsWhiteSpace(currentChar)) //ตรวจสอบว่าตัวอักษรที่กำหนดเป็นช่องว่างหรือไม่
                {
                        continue; // Skip whitespace
                    }
                if (char.IsDigit(currentChar)) //ตรวจสอบว่าตัวอักษรที่กำหนดเป็นตัวเลขหรือไม่ 
                {
                    postfixBuilder.Append(currentChar);
                }
                else if ("+-*/".Contains(currentChar))
                {
                    if ((i + 1) < text.Length && char.IsDigit(text[i + 1])) 
                    {
                        postfixBuilder.Append(text[i+1]);
                        postfixBuilder.Append(currentChar);
                        i++;
                    }
                    else 
                    {
                        throw new ArgumentException("Invalid expression: Missing operand after operator.");
                    }
                }
                }
                return postfixBuilder.ToString();
        }
        public static int CalculatePostfix(string text) 
        {
            String Postfix = ConvertInfixToPostfix(text);
            Stack Stack = new ArrayStack(Postfix.Length);
            foreach (char ch in Postfix)
            {
                if (char.IsDigit(ch)) //ตรวจสอบว่าตัวอักษรที่กำหนดเป็นตัวเลขหรือไม่ 
                {
                    Stack.push(int.Parse(ch.ToString())); // ดันค่าถูกดำเนินการลงบนสแต็ก
                }
                else 
                {
                    if (Stack.size() < 2) 
                    {
                        throw new InvalidOperationException("Invalid postfix expression: Not enough operands.");
                    }
                    int operand1 = (int)Stack.pop(), operand2 = (int)Stack.pop(), result; 
                    switch (ch)
                    {
                        case '+':
                            result = operand2 + operand1;
                            break;
                        case '-':
                            result = operand2 - operand1;
                            break;
                        case '*':
                            result = operand2 * operand1;
                            break;
                        case '/':
                            result = operand2 / operand1;
                            break;
                        default:
                            throw new InvalidOperationException($"Unsupported operator: {ch}");
                    }
                    Stack.push(result);
                }  
            }
            if (Stack.size() != 1)
            {
                throw new InvalidOperationException("Invalid postfix expression: Incorrect number of results.");
            }
            return (int)Stack.pop();   // Final result
        }
    }
}
