namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoListDemo();
            DoStackDemo();
            DoQueueDemo();
            DoSetDemo();
            DoDictionaryDemo();
        }
        private static void DoListDemo()
        {
            Console.WriteLine("In Do List Demo");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");
            foreach(var elements in list)
            {
                Console.WriteLine(elements);
            }
        }
        private static void DoStackDemo()   //Stack represents a last-in, first out collection of object.
        {
            Console.WriteLine("\nIn Stack Demo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");
            string pop=stack.Pop();
            foreach (var elements in stack)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine("Poped Element: "+pop);
        }
        private static void DoQueueDemo()   //stores the elements in FIFO style (First In First Out)
        {
            Console.WriteLine("\nIn Queue Demo");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("JaiShankar");
            queue.Enqueue("Raj");
            Console.WriteLine("Head:"+queue.Peek());
            Console.WriteLine("\nIterating the queue elements:");
            foreach(var elements in queue)
            {
                Console.WriteLine(elements);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Deque element:"+dequeue);
            Console.WriteLine("\nIterating the queue elements after deque one element:");
            Queue<string>.Enumerator enumerator= queue.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void DoSetDemo() //Doesnt allow to store duplicates. 
        {
            Console.WriteLine("\nIn Do Set Demo");

            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");
            HashSet<string>.Enumerator enumerator= set.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void DoDictionaryDemo()  //Dictionary is a generic collection which is generally used to store key/value pairs.
        {
            Console.WriteLine("In Do Dictionsry Demo");
            Dictionary<int,string> dictionary=new Dictionary<int,string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");
            Console.WriteLine("Access value using key(key=100): "+dictionary[100]);
            Console.WriteLine("\nIterating Dictionary: ");
            foreach(var element in dictionary)
            {
                Console.WriteLine("Key ="+element.Key+" & value ="+element.Value);
            }
        }
    }
}