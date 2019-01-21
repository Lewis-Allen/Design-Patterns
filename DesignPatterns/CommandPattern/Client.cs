namespace CommandPattern
{
    public class Client
    {
        public static void Main()
        {
            ISwitchable light = new Light();
            ISwitchable television = new Television();

            ICommand lightOff = new OffSwitchCommand(light);
            ICommand lightOn = new OnSwitchCommand(light);

            ICommand tvOff = new OffSwitchCommand(television);
            ICommand tvOn = new OnSwitchCommand(television);

            lightOff.Execute();
            tvOn.Execute();

            lightOn.Execute();
            tvOff.Execute();
        }
    }
}
