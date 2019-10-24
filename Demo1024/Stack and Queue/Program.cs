using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // stacks
            // declaration
            Stack<Student> stackofStudents = new Stack<Student>();

            // push objects onto stack
            stackofStudents.Push(new Student("Bill"));
            stackofStudents.Push(new Student("Jill"));
            stackofStudents.Push(new Student("Jack"));

            // traversal
            foreach (Student s in stackofStudents)
            {
                Console.WriteLine(s.Name);
                
            }
            
            Console.WriteLine();
            Console.WriteLine("stackofStudents.Count = {0}", stackofStudents.Count);

            // pops
            int size = stackofStudents.Count;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(stackofStudents.Pop().Name);

            }

            Console.WriteLine();
            Console.WriteLine("After pops. stackofStudents.Count = {0}", stackofStudents.Count);

            // queue
            Queue<Student> studentQueue = new Queue<Student>(); // queue declaration

            // put items in queue
            studentQueue.Enqueue(new Student("Bill"));
            studentQueue.Enqueue(new Student("Jill"));
            studentQueue.Enqueue(new Student("Jack"));

            // traversal
            foreach (Student s in studentQueue)
            {
                Console.WriteLine(s.Name);

            }
            
            Console.WriteLine();
            Console.WriteLine("stackofQueue.Count = {0}", studentQueue.Count);
            Console.WriteLine();


            size = studentQueue.Count;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(studentQueue.Dequeue().Name);
            }

            Console.WriteLine();
            Console.WriteLine("after Dequeue stackofQueue.Count = {0}", studentQueue.Count);
            Console.WriteLine();
        }
    }
}
