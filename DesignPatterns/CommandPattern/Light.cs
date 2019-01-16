using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
