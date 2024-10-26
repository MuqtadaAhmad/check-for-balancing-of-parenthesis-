using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace مسودة
{
     class Stack1
    {
        int top;
        int size;
        char[] stackarr;
        public Stack1(int ele)
        {
            size = ele;
             top = -1;
            stackarr = new char[size];
        }
        public void push(char ele)
        {
            if (ele == '[' || ele == '{' || ele == '(')
            {
                stackarr[++top] = ele;
            }
        
        }
        public char pop()
        {
            return stackarr[top--];
        }
        public bool isEmty()
        {
            return (top==-1);
        }
        public bool isFull()
        {

            return (top==size-1);
        }
        public char peek()
        {
            return (stackarr[top]);
        }
        public int stackSize()
        {
            return top + 1;
        }
        public char ip(char x)
        {
            switch (x)
            {
                case '}':
                        return '{';

                case ']':
                    return '[';

                case ')':
                    return '(';
            }
            return '0';
                
        }

    }
}
