namespace SingletonPattern.ThreadSafe
{
    public sealed class Singleton
    {
        private static volatile Singleton _instance;
        private static object _syncRoot = new object();

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                            _instance = new Singleton();
                    }
                }

                return _instance;
            }
        }
    }
}
