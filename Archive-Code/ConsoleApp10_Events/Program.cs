using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10_Events
{
    public class ChildEventArgument:EventArgs
    {
        public int OldAge { get; set; }
        public int NewAge { get; set; }
    }
    public class Child
    {
        public event EventHandler<ChildEventArgument> AgeChanged;
        public int _age;
        public int Age
        {
            get { return _age; }
            set {
                ChildEventArgument arg = new ChildEventArgument
                {
                    NewAge = value,
                    OldAge = _age
                };
                _age = value;
                AgeChanged?.Invoke(this, arg);
            }
        }
    }
    public class Parent
    {
        public Child _child { get; set; }
        public Parent(Child child)
        {
            _child = child;
            _child.AgeChanged += _child_AgeChanged;
        }

        private void _child_AgeChanged(object sender, ChildEventArgument e)
        {
            Console.WriteLine($" new age is: {e.NewAge}, old age is : {e.OldAge} from Parent");
        }
    }
    public class GrandFather
    {
        public Child _child { get; set; }
        public GrandFather(Child child)
        {
            _child = child;
            _child.AgeChanged += _child_AgeChanged;
        }

        private void _child_AgeChanged(object sender, ChildEventArgument e)
        {
            Console.WriteLine($" new age is: {e.NewAge}, old age is : {e.OldAge} from Parent");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            Parent p = new Parent(c);
            GrandFather g = new GrandFather(c);
            c.Age = 12;
            c.Age = 15;
            Console.ReadLine();
        }
    }
}
