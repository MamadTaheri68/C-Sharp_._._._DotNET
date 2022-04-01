using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.intLinkedList
{
    public class BoolNode
    {
        public int Value { get; set; }

        public BoolNode Next { get; set; }
        public BoolNode Prev { get; set; }

    }

    public class BoolLinkedList : IEnumerable
    {

        public BoolNode First { get; set; }

        public BoolNode Last { get; set; }


        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
