using System;

namespace CommandPattern
{
    public class Light : ISwitchable
    {
        public void PowerOff()
        {
            Console.WriteLine("The light has been turned off.");
        }

        public void PowerOn()
        {
            Console.WriteLine("The light has been turned on.");
        }
    }
}
