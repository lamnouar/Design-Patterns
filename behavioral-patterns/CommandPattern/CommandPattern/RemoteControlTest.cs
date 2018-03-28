namespace CommandPattern
{
    class RemoteControlTest
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl simpleRemoteControl = new SimpleRemoteControl();
            Light light = new Light();
            LightOnCommand lightOnCommand = new LightOnCommand(light);
            simpleRemoteControl.Command = lightOnCommand;

            simpleRemoteControl.PressButton();

            LightOffCommand lightOffCommand = new LightOffCommand(light);
            simpleRemoteControl.Command = lightOffCommand;

            simpleRemoteControl.PressButton();
        }
    }
}
