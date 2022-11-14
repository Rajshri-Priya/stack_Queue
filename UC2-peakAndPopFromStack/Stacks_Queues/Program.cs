namespace Stacks_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Stacks and Queues");
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("\n--------stack elements--------");
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Display();
            stack.Peek();
            stack.Pop();
            Console.WriteLine();
            stack.Display();
        }
    }
}