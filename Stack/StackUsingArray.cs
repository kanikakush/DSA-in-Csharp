using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    internal class StackUsingArray
    {/*
       Fundamental operations of stack
          Pop()
          push(Data)
          Peek() -top most element of the stack
          isEmpty() -null/ underflow condition
          initially top=-1(empty array)
          isFull()- overflow condition*/
        static int size = 5;
        static int top = -1;
        int[] StackArray = new int[size];
        int i;
       public void StackElementDisplay()
        {
          Console.WriteLine("Current elements in stack");
            for (i = 0; i <=top; i++)
            {

                Console.WriteLine(StackArray[i]);
            }

        }
       
        public void Push(int data)
        {
            if (isFull())
                return;
            top++;
            StackArray[top] = data;
        }
        public void Pop()
        {
            if (isEmpty())
                return;
            top--;
        }
        public int PeekValue()
        {

            return StackArray[top];
        }
        public Boolean isEmpty()
        {
            if (top==-1)
                return true;
            else
                return false;
        }
        public Boolean isFull()
        {
            if (top == size - 1)
                return true;
            else
                return false;
        }

        /*Applications of stack
          1. reverse of string
          2. Undo operation
          3. recusion/function call
          4. Balancing of paraenthises(){}[]
          5. Tower of houni
         */
    }
     

}
