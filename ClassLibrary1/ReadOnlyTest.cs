using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ReadOnlyTest
    {
        private readonly int _count;

        public ReadOnlyTest(int cnt)
        {
            _count = cnt;
        }
    }
}
