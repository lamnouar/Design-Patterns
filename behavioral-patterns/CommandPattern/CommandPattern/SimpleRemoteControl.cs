namespace CommandPattern
{
    /// <summary>
    /// Invoker
    /// </summary>
    public class SimpleRemoteControl
    {
        public ICommand Command { set; get; }

        public void PressButton()
        {
            Command.Execute();
        }
    }
}
