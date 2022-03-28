using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SingleTonTest
    {
        public int Test { get; set; } = 1;
        private static SingleTonTest _singletoneTest;
        private SingleTonTest()
        {

        }

        public static SingleTonTest GetInstance()
        {
            if (_singletoneTest == null)
            {
                _singletoneTest = new SingleTonTest();
            }
            return _singletoneTest;
        }
    }
}
