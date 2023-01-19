using System;
using System.Collections.Generic;
using System.Text;

namespace UC_stack_queue
{
    internal class StackQueue
    {
       public Node top;
        public void push(int data)
        {
            Node node = new Node();
            node.data = data;
            if(top== null)
            {
                top= node;
            }
            else
            {
                node.next = top;
                top = node;
            }
            

        }
        public void show()
        {
            Node temp= top;
            while(temp!=null)
            {
                Console.WriteLine(temp.data);
                temp= temp.next;
            }
        }
    }
}
