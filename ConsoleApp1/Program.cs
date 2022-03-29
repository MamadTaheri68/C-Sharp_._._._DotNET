using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace ConsoleApp1
{
    public class Person : IEquatable<Person>
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string SSN { get; set; }
        public bool Equals(Person other)
        {
            return Fname == other.Fname;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //List *********************************
            //List<int> mylist01 = new List<int>()
            //{
            //    1,
            //    2,
            //    3,
            //    4,
            //};

            //mylist01.Add(52);
            //mylist01.Remove(1);
            //mylist01.RemoveAt(1);
            //mylist01.TrimExcess();
            //mylist01.Find();
            //mylist01.IndexOf(3);
            //mylist01.Sort();
            //mylist01.Count();
            //var a = mylist01.Capacity;
            //mylist01.AsReadOnly();

            //LinkedList *********************************
            //Fast Insert & Delete - Slow Search 
            LinkedList<int> linkedlist = new LinkedList<int>();
            linkedlist.AddFirst(1);
            var firstItem = linkedlist.Find(1);
            linkedlist.AddAfter(firstItem, 3);
            linkedlist.AddAfter(firstItem, 2);
            linkedlist.AddLast(5);

            //Queue *********************************
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            var value1 = myQueue.Peek();
            var value2 = myQueue.Dequeue();

            //Stack *********************************
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Peek();
            myStack.Pop();

            //SortedList *********************************
            SortedList<string, Person> slist = new SortedList<string, Person>();
            var person = new Person
            {
                SSN = "11111",
                Fname = "Mamad",
                Lname = "Taheri"
            };
            slist.Add(person.SSN, person);

            //Dictionary *********************************
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "mamad");
            myDictionary.Add(2, "zahra");
            myDictionary.Add(3, "Ali");
            foreach (var item in myDictionary)
            {
                Console.WriteLine(item.Value);
            }

            //HashSet ********************************
            HashSet<int> myHashSet01 = new HashSet<int>
            {
                1,2,3,5,6,0
            };
            HashSet<int> myHashSet02 = new HashSet<int>
            {
                1,2
            };




        }

    }
}
