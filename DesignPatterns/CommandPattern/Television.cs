using System;

namespace CommandPattern
{
    public class Television : ISwitchable
    {
        public void PowerOff()
        {
            Console.WriteLine("The television has been turned off.");
        }

        public void PowerOn()
        {
            Console.WriteLine("The television has been turned on.");
        }
    }
}
