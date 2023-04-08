using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerWindowsFormsApp
{
    internal class QueueDataStructure
    {
        private Customer[] store;// array to hold the data
        private int headIndex;  // index of the head
        private int tailIndex; // index of the tail
        private int numItems; // number of items in the queue
        private int maxSize; // maximum size of the queue

        public QueueDataStructure(int size)
        {
            store = new Customer[size];
            headIndex = 0;
            tailIndex = 0;
            numItems = 0;
            maxSize = size;
        }

        public int Count
        {
            get { return numItems; }
            set { numItems = value; }
        }

        public Customer[] Store
        {
            get { return store; }
            set { store = value; } 
        }

        public void Enqueue(Customer element)
        {
            if (IsEmpty())
            {
                headIndex = 0;
                tailIndex = 0;
                store[tailIndex] = element;
                numItems++;
                return;
            }

            if (IsFull())
            {
                MessageBox.Show("Queue is full. Cannot add more items.", "Queue full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tailIndex = (tailIndex + 1) % maxSize;
            store[tailIndex] = element;
            numItems++;

        }

        public Customer Dequeue()
        {
            if (IsEmpty())
            {
                MessageBox.Show("Queue is empty. Cannot remove items.", "Queue Underflow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            Customer headItem = store[headIndex];
            headIndex = (headIndex + 1) % maxSize;
            numItems--;

            return headItem;
        }

        public Customer Peek()
        {
            if (IsEmpty())
            {
                MessageBox.Show("Queue is empty.", "Peek", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return store[headIndex];
        }

        public bool IsEmpty()
        {
            return numItems == 0;
        }

        public bool IsFull()
        {
            return numItems == maxSize;
        }

        public void ReverseKElements(int k)
        {
            if (k > numItems)
            {
                MessageBox.Show("The queue contains less than k elements.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (k == 1)
            {
                return; // no need to reverse a single element
            }

            // create a temporary stack to hold the first k elements of the queue
            Stack<Customer> stack = new Stack<Customer>();
            int count = 0;
            while (count < k)
            {
                stack.Push(Dequeue());
                count++;
            }

            // push the elements from the temporary stack back into the queue
            while (stack.Count > 0)
            {
                Enqueue(stack.Pop());
            }
        }

    }


}
