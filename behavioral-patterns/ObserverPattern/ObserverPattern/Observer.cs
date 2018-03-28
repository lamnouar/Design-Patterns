namespace ObserverPattern
{
    public interface Observer
    {
        void Update(float temperature, float humidity, float pressure);
    }
}