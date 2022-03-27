using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FirstClass
    {
        private int _age;
        public void SetAge(int age)
        {
            _age = age;
        }
        public int GetAge()
        {
            return _age;
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public int MyProperty2 { get; }
        public int MyProperty3 { get; private set; } = 12;

        public string Fullname => $"{MyProperty2} {MyProperty3}";

    }
}
