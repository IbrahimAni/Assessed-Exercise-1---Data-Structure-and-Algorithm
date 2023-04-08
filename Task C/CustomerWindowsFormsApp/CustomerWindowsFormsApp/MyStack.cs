using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWindowsFormsApp
{

    public class MyStack
    {
        private int[] data;
        private int top;

        public MyStack(int size)
        {
            data = new int[size];
            top = -1;
        }

        public void Push(int value)
        {
            if (top >= data.Length - 1)
            {
                throw new Exception("Stack is full");
            }

            top++;
            data[top] = value;
        }

        public int Pop()
        {
            if (top < 0)
            {
                throw new Exception("Stack is empty");
            }

            int value = data[top];
            top--;
            return value;
        }

        public int Peek()
        {
            if (top < 0)
            {
                throw new Exception("Stack is empty");
            }

            return data[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == data.Length - 1;
        }
    }

}
