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

        private Nullable<int> _testNull;

        private int? _testNull01;

        int testA = 0;

        public ReadOnlyTest(int cnt)
        {
            _count = cnt;
            //if (_testNull01.HasValue)
            //{
            //    testA = _testNull01.Value;
            //} else
            //{
            //    testA = 1;
            //}

            testA = _testNull01 ?? 1;
        }

        // Nullable
      

    }
}
