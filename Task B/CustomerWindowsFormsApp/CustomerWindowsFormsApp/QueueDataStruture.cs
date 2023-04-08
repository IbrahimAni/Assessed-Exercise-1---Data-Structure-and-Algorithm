using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerWindowsFormsApp
{
    // This code defines a class called QueueDataStruture which implements a queue data structure using an array of Customer objects.
    internal class QueueDataStruture
    {
        private Customer[] array; // array to hold the data
        private int head; // position of the head
        private int tail; // position of the tail
        private int count; // number of items in the queue
        private int maxSize; // maximum size of the queue

        // The constructor for the QueueDataStruture class takes a single parameter, which is the maximum size of the queue.
        public QueueDataStruture(int size)
        {
            array = new Customer[size];
            head = 0;
            tail = 0;
            count = 0;
            maxSize = size;
        }

        // The Count property of the QueueDataStruture class allows the number of items in the queue to be retrieved or set.
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        // The Enqueue method of the QueueDataStruture class adds a new element to the end of the queue.
        public void Enqueue(Customer element)
        {
            // If the queue is full, show a message box and return without adding the new element.
            if (count == maxSize)
            {
                MessageBox.Show("Queue is full. Cannot add more items.", "Queue full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add the new element to the end of the queue.
            array[tail] = element;
            tail++;
            count++;
            Console.WriteLine($"Customer {element.Name} Added");
        }

        // The Dequeue method of the QueueDataStruture class removes and returns the element at the front of the queue.
        public Customer Dequeue()
        {
            // If the queue is empty, show a message box and return null.
            if (IsEmpty())
            {
                MessageBox.Show("Queue is empty. Cannot remove more customers.", "Queue Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            // Remove and return the element at the front of the queue.
            Customer element = array[head];
            array[head] = null;
            head++;
            count--;
            Console.WriteLine($"Customer {element.Name} Removed");
            return element;
        }



        public Customer Peek()
        {
            // If the queue is empty, show a message box and return null.
            if (count == 0)
            {
                MessageBox.Show("Queue is empty.", "IsEmpty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            // Return the element at the front of the queue.
            return array[head];
        }

        // The IsEmpty method of the QueueDataStruture class returns true if the queue is empty, false otherwise.
        public bool IsEmpty()
        {
            return count == 0;
        }

        // The isFull method of the QueueDataStruture class returns true if the queue is full, false otherwise.
        public bool isFull()
        {
            return count == maxSize;
        }
    }

}
