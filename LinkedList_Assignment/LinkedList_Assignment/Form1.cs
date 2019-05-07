using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class node
        {
            public int data;
            public node next;


        }


        public class linkedList
        {
            public node head;

            public void Add(int data)
            {
                if(head == null)
                {
                    head = new node();
                    head.data = data;
                }
                else
                {
                    node temp = head;
                    while(temp.next!=null)
                    {
                        temp = temp.next;
                    }
                    temp.next = new node();
                    temp.next.data = data;
                }
            }
        }
        Stack s = new Stack();
        Queue q = new Queue();
        


        public class Stack:linkedList
        {
            public int pop()
            {
                node temp = head;
                node temp2 = head;
                while(temp.next != null)
                {
                    temp2 = temp;
                    temp = temp.next;
                }
                if (temp==head)
                {
                    int returnValue = temp.data;
                    head = null;
                    return returnValue;
                }
                else
                {
                    int returnValue = temp.data;
                    temp2.next = null;
                    return returnValue;
                }
            }

        }
        class Queue : linkedList
        {
            public int dequeue()
            {
                int returnValue = head.data;
                head = head.next;
                return returnValue;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s.Add(int.Parse(textBox1.Text));
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = s.pop().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            q.Add(int.Parse(textBox4.Text));
            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = q.dequeue().ToString();
        }
    }
}
