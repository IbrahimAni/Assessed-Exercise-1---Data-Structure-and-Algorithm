using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerWindowsFormsApp
{
    // This code defines a form called Form1 which allows the user to interact with a queue data structure implemented using the QueueDataStruture class.
    public partial class Form1 : Form
    {
        private QueueDataStruture qds;

        // The constructor for the Form1 class initializes a new instance of the QueueDataStruture class with a maximum size of 3, and sets the text of the label1 control to the current number of customers in the queue.
        public Form1()
        {
            InitializeComponent();
            qds = new QueueDataStruture(3);
            label1.Text = $"Customer in Queue: {qds.Count}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // The Dequeue_Click method of the Form1 class removes the first customer from the queue, removes their name from the listBox1 control, and updates the text of the label1 control to reflect the current number of customers in the queue.
        private void Dequeue_Click(object sender, EventArgs e)
        {
            Customer c = qds.Dequeue();
            if (c != null)
            {
                listBox1.Items.RemoveAt(0);
                label1.Text = $"Customer in Queue: {qds.Count}";
            }
        }

        // The Enqueue_Click method of the Form1 class adds a new customer to the end of the queue, adds their name to the listBox1 control, and updates the text of the label1 control to reflect the current number of customers in the queue. If the queue is full or the user has not entered a name, an error message is shown and the method returns without adding the new customer.
        private void Enqueue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Customer c = new Customer(textBox1.Text);
            if (qds.isFull())
            {
                MessageBox.Show("Queue is full. Cannot add more customers.", "Queue Overflow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                qds.Enqueue(c);
                label1.Text = $"Customer in Queue: {qds.Count}";
                listBox1.Items.Add(c.Name);
            }
            textBox1.Clear();
        }
    }
}
