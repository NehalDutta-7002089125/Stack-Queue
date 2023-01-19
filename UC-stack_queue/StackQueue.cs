using System;
using System.Collections.Generic;
using System.Text;

namespace UC_stack_queue
{
    internal class StackQueue
    {
       public Node front;
        public Node rare;
        public void enqueue(int data)
        {
            Node node = new Node();
            node.data = data;
            if(front== null)
            {
                front = node;
                rare= node;
            }
            else
            {
                rare.next= node;
                rare=node;
            }
            

        }
        public void show()
        {
            Node temp= front;
            while(temp!=null)
            {
                Console.WriteLine(temp.data);
                temp= temp.next;
            }
        }
    }
}
