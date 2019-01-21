namespace CommandPattern
{
    /// <summary>
    /// This is equivalent to the invoker class
    /// </summary>
    public class Switch
    {
        ICommand offCommand;
        ICommand onCommand;

        public Switch(ICommand offCommand, ICommand onCommand)
        {
            this.offCommand = offCommand;
            this.onCommand = onCommand;
        }

        public void Off()
        {
            this.offCommand.Execute();
        }

        public void On()
        {
            this.onCommand.Execute();
        }
    }
}
