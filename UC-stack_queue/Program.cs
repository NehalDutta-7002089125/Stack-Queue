using System;

namespace UC_stack_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackQueue a=new StackQueue();
            a.enqueue(56);
            a.enqueue(30);
            a.enqueue(70);
            a.dequeue();
            a.dequeue();
            a.dequeue();
            a.dequeue();
            a.show();
        }
    }
}
