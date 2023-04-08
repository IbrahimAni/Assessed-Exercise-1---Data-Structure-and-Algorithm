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
    public partial class Form1 : Form
    {
        private QueueDataStructure qds;

        public Form1()
        {
            InitializeComponent();
            qds = new QueueDataStructure(5);
            label1.Text = $"Customer in Queue: {qds.Count}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Dequeue_Click(object sender, EventArgs e)
        {
            Customer c = qds.Dequeue();
            if (c != null)
            {
                listBox1.Items.RemoveAt(0);
                label1.Text = $"Customer in Queue: {qds.Count}";
            }
        }

        private void Enqueue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int value;
            if (int.TryParse(textBox2.Text, out value))
            {
                // Conversion succeeded, use the integer value here
                Customer c = new Customer(textBox1.Text, value);

                if (qds.IsFull())
                {
                    MessageBox.Show("Queue is full. Cannot add more customers.", "Queue Overflow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    qds.Enqueue(c);
                    label1.Text = $"Customer in Queue: {qds.Count}";
                    listBox1.Items.Add($"{c.Name} {c.Age}");
                }
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                // Conversion failed, show an error message to the user
                MessageBox.Show("Please enter a valid integer into the age textbox.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (!int.TryParse(textBox3.Text, out k))
            {
                MessageBox.Show("Please enter a valid integer into the k textbox.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            qds.ReverseKElements(k);
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            listBox1.Items.Clear();
            foreach (Customer c in qds.Store)
            {
                if (c != null)
                {
                    listBox1.Items.Add($"{c.Name} {c.Age}");
                }
            }
        }

    }
}
