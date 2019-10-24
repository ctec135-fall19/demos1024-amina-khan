using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // delaration
            Dictionary<string, Student> studentDictionary = 
                new Dictionary<string, Student>();

            // initialization different ways
            studentDictionary.Add("Bill", new Student("vBill"));
            studentDictionary["Jill"] = new Student("vJill");
            studentDictionary["Jack"] = new Student("vJack");

            // traversal
            foreach (string key in studentDictionary.Keys) // using key for refferencing keys
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            foreach (Student s in studentDictionary.Values) // using values
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();


        }
    }
}
