#define funkewashere
#undef funkegone
namespace csharptutsproject

{
    //IEnumerable

    public class Program
    {

        //stack === LIFO ----- LastIN FirstOut
        //queue === FIFO ----- FirstIn FirstOut
        //Dictionary === is a key value pair


        public static void Main()
        {
            Dictionary<int, string> data = new Dictionary<int, string>();

            data.Add(1, "one");
            data.Add(2, "two");
            data.Add(45, "fortyfive");

            foreach(KeyValuePair<int,string> kvp in data)
            {
                Console.WriteLine(kvp.Value);
            }



            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(1);
            set.Add(1);
            set.Add(1);

            foreach (int i in set)
            {
                Console.WriteLine(i);
            }

            //string[] words = { "joy", "word", "doll" };

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);


            //Console.WriteLine(stack.Peek());
            //stack.Pop();
            //Console.WriteLine(stack.Peek());
            //stack.Pop();
            //Console.WriteLine(stack.Peek());

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("word");
            //queue.Enqueue("chalk");
            //queue.Enqueue("top");
            //queue.Enqueue("left");
            //Console.WriteLine(queue.Peek());
            ////queue.Dequeue();
            //Console.WriteLine(queue.Peek());
            ////queue.Dequeue();
            //Console.WriteLine(queue.Peek());
            ////queue.Dequeue();
            //Console.WriteLine(queue.Peek());

            //List<int> list = stack.ToList();
            //list.Add(list[0]);
            //list.Add(list[1]);
            //list.Add(list[3]);



        }
        
      




    }
    

}

