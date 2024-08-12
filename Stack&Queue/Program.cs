using Stack_Queue;
namespace Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { 123, 456, 789 };
            Stack<int> s = new Stack<int>(ar);
            s.Push(10);
            s.Push(20);
            s.Push(30);

            s.Pop();
            
            foreach (int i in s)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(s.Count);
            Console.WriteLine(s.Peek()); //20
            Console.WriteLine(" -- Queue -- ");
            // Queue Fifo frist in first out
            Queue<int > Q= new Queue<int>(ar);
            Q.Enqueue(10);
            Q.Enqueue(20);
            Q.Enqueue(30);
            Q.Dequeue();

            foreach (int i in Q) { 
                Console.WriteLine(i);
            }
            Console.WriteLine(Q.Count);
            Console.WriteLine(Q.Peek());

        }
    }
}
