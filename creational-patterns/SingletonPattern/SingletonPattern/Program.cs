using SingletonPattern.ThreadSafe;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s = Singleton.Instance;
        }
    }
}
