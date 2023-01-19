using System;

namespace UC_stack_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackQueue a=new StackQueue();
            a.push(70);
            a.push(30);
            a.push(56);
             a.pop();
            a.pop();
            a.pop();
            a.pop();
            a.show();
        }
    }
}
