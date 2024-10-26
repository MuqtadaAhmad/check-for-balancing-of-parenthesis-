using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
namespace مسودة
{

   
    internal class Program
    {
         class Stack
        {
           public int size;
            int top;
            char[] Stackarr;

            public Stack(int ele)
            {
                size = ele;
                top = -1;
                Stackarr = new char[size];
            }
            public bool isEmut()
            {

                return (top == -1);
            }
            public bool isFull()
            {
                return (top == size - 1);
            }
            public void push (char ele)
            {
                Stackarr[++top] = ele;
            
            }
            public char pop()
            {
                return Stackarr[top--];
            }
            public char Peek()
            {
                return Stackarr[top];
            }
            public int sizeStack()
            {
                return top + 1;
            
            }













        }
       

        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }
    }
}
