namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack();
            //stack.Push(70);
            //stack.Push(30);
            //stack.Push(56);
            //stack.Display();
            //stack.Peak();
            //stack.Pop();
            //stack.Peak();
            //stack.Pop();
            //stack.Peak();
            //stack.Pop();
            Queue queue = new Queue();
            queue.Append(56);
            queue.Append(30);
            queue.Append(70);
            queue.Display();
        }   
    }    
}