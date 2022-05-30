# How To create an Singletone Class in C#?

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

    //test